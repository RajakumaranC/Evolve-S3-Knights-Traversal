namespace KnightTraversal
{
    public class Point
    {
        public int row;
        public int col;
        
        public Point Previous = null;
        public Point Next = null;

        public Point(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}