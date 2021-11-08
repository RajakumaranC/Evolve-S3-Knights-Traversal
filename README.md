# Evolve Season 3 - Mini Project

## Problem statement:

    Given a chessboard of size 8X8, initial position of knight and desired position of knight, you need to find best possible knight’s movements in a game to reach final position. In a chess game, a knight’s basic move is two squares horizontally and one square vertically or two squares vertically and one square horizontally.

## Inputs:

    - Grid of size 8x8 - Representing a chess board
    - Initial Position of knight - int[2] which represent row and col position.
    - Final Poisiton of Knight - int[2] which represent row and col position

## Output:

    - List containing the best cordinate for the knight to move from starting to finishing position. 
    (This is an optimization problem)

![Knight Moves](knightmoves.gif)


## Logic

    1. At any given position, the knight can move in one of 8 direciton
    1. i-2, j-1
    1. i-1, j-2
    1. i-1, j+2
    1. i-2, j+1
    1. i+1, j-2
    1. i+1, j+2
    1. i+2, j-1
    1. i+2, j+1

    2. We need the shortest path, so we need to establish a traversal method. --> Gonna go with DFS. Reason is DFS is much simpler in implementation although it uses stack. (probably we can upgrade to BFS if we get a working solution running).

    3. Since it involves recursion, what is my base cases? 
    -   if either i or j is out of bounds we return null. 
    -   if current position is == end position --> we declare a empty list, then add the value which called the base condition to it. 

    4. 
