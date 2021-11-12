using System;
using System.Collections.Generic;


namespace KnightTraversal
{
    public partial class KnightTraversal
    {
        private readonly int[] start;
        private readonly int[] dest;
        private static int[] cx = {1, 1, 2, 2, -1, -1, -2, -2};
        private static int[] cy = {2, -2, 1, -1, 2, -2, 1, -1};
        public readonly int N;
        private readonly HashSet<(int, int)> visited;

        public KnightTraversal(int[] start, int[] dest, int n)
        {
            this.N = n;

            if(start == null || dest == null || start.Length != 2 || dest.Length != 2)
                throw new ArgumentException("start and detination array are not in the right formats");

            if(!WithinRange(dest[0], dest[1]) || !WithinRange(start[0], start[1]))
                throw new ArgumentException("Invalid board or start and/or destination positions are outside of the board's boundry");
            
            this.start = start;
            this.dest = dest;
            this.visited = new HashSet<(int, int)>();
        }


        public List<int[]> BuildPath()
        {
            var point = BFS_Helper(dest[0], dest[1]);
            return BuildPathList_Helper(point);
        }

        private List<int[]> BuildPathList_Helper(Point point)
        {
            if(point == null)
                return new List<int[]>();

            var result = new List<int[]>();

            while(point != null)
            {
                int[] current = {point.row, point.col};
                result.Add(current);
                point = point.Previous;
            }

            return result;
        }

        private Point BFS_Helper(int i, int j)
        {
            if( !WithinRange(i, j) ) return null;

            Queue<Point> queue = new Queue<Point>();
            Point start = new Point(i, j);
            
            visited.Add( (i,j) );
            
            queue.Enqueue(start);

            Point current = null;

            while(queue.Count > 0)
            {
                current = queue.Peek(); 
                queue.Dequeue();

                if( IsDestination(current) )
                {
                    return current;
                }
                   
                for(int idx = 0; idx < 8; idx++)
                {
                    int rowNext = current.row + cx[idx];
                    int colNext = current.col + cy[idx];

                    if( WithinRange(rowNext, colNext) && !visited.Contains( (rowNext, colNext) ) )
                    {
                        Point nextPoint = new Point(rowNext, colNext);
                        nextPoint.Previous = current;
                        queue.Enqueue(nextPoint);
                        visited.Add( (rowNext, colNext) );
                    }
                }
                
            }

            return current;
        }

        private bool WithinRange(int i, int j)
        {
            if(i < 0 || i >= N || j < 0 || j >= N)
                return false;
            
            return true;
        }

        private bool IsDestination(Point point)
        {
            if(point.row != start[0] || point.col != start[1])
                return false;

            return true;
        }
    }
}