using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
    int n = maps.GetLength(0);
    int m = maps.GetLength(1);

    int[] right = new int[2] { 1, 0 };
    int[] up    = new int[2] { 0, -1 };
    int[] left  = new int[2] { -1, 0 };
    int[] down  = new int[2] { 0, 1 };

    int[][] turnArry = new int[4][];
    turnArry[0] = right;
    turnArry[1] = up;
    turnArry[2] = left;
    turnArry[3] = down;

    int turnIndex = 0;
    int[] currentDir = turnArry[turnIndex % 4];

    int nowX = 0;
    int nowY = 0;            

    bool[,] visited = new bool[n, m];
    int[,] costs = new int[n, m];
    Queue<Position> positionQueue = new Queue<Position>();
    positionQueue.Enqueue(new Position(nowX, nowY));
    visited[nowX, nowY] = true;
    costs[nowX, nowY] = 1;

    while (positionQueue.Count > 0)
    {
        Position pos = positionQueue.Dequeue();
        nowX = pos.x;
        nowY = pos.y;

        if (nowX == n && nowY == m)
            break;

        for (int i = 0; i < 4; i++)
        {
            currentDir = turnArry[turnIndex % 4];
            turnIndex++;

            Position nextPos = new Position(nowX + currentDir[0], nowY + currentDir[1]);

            if (nextPos.x == -1 || nextPos.y == -1 || nextPos.x == n || nextPos.y == m)
                continue;
            if (visited[nextPos.x, nextPos.y] || maps[nextPos.x, nextPos.y] == 0)
                continue;

            visited[nextPos.x, nextPos.y] = true;
            costs[nextPos.x, nextPos.y] = costs[nowX, nowY] + 1;
            positionQueue.Enqueue(nextPos);
        }
    }

    if (!visited[n - 1, m - 1])
        return -1;

    return costs[n - 1, m - 1];
}
    public struct Position
{
    public int x;
    public int y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }            
}
}