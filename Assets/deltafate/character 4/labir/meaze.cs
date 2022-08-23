using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatormaze
{
    int with = 20; int helig = 20;
    public generatormazecell[,] generatoratemaze()
    {
        generatormazecell[,] mase = new generatormazecell[with,helig];
        for (int x = 0;x<mase.GetLength(0); x++)
        {
            for (int y = 0; y < mase.GetLength(1); y++)
            {
                mase[x,y] = new generatormazecell{X = x,Y = y};
            }
        }
        removestena(mase);
        return mase;
    }
    public void removestena(generatormazecell[,] mase)
    {
        generatormazecell current = mase[0, 0];
        current.Visited = true;
        current.DistanceFromStart = 0;

        Stack<generatormazecell> stack = new Stack<generatormazecell>();
        do
        {
            List<generatormazecell> unvisitedNeighbours = new List<generatormazecell>();

            int x = current.X;
            int y = current.Y;

            if (x > 0 && !mase[x - 1, y].Visited) unvisitedNeighbours.Add(mase[x - 1, y]);
            if (y > 0 && !mase[x, y - 1].Visited) unvisitedNeighbours.Add(mase[x, y - 1]);
            if (x < with - 2 && !mase[x + 1, y].Visited) unvisitedNeighbours.Add(mase[x + 1, y]);
            if (y < helig - 2 && !mase[x, y + 1].Visited) unvisitedNeighbours.Add(mase[x, y + 1]);

            if (unvisitedNeighbours.Count > 0)
            {
                generatormazecell chosen = unvisitedNeighbours[UnityEngine.Random.Range(0, unvisitedNeighbours.Count)];
                RemoveWall(current, chosen);

                chosen.Visited = true;
                stack.Push(chosen);
                chosen.DistanceFromStart = current.DistanceFromStart + 1;
                current = chosen;
            }
            else
            {
                current = stack.Pop();
            }
        } while (stack.Count > 0);
    }

    private void RemoveWall(generatormazecell a, generatormazecell b)
    {
        if (a.X == b.X)
        {
            if (a.Y > b.Y) a.down= false;
            else b.down= false;
        }
        else
        {
            if (a.X > b.X) a.left = false;
            else b.left = false;
        }
    }

    private Vector2Int PlaceMazeExit(generatormazecell[,] mase)
    {
        generatormazecell furthest = mase[0, 0];

        for (int x = 0; x < mase.GetLength(0); x++)
        {
            if (mase[x, helig - 2].DistanceFromStart > furthest.DistanceFromStart) furthest = mase[x, helig - 2];
            if (mase[x, 0].DistanceFromStart > furthest.DistanceFromStart) furthest = mase[x, 0];
        }

        for (int y = 0; y < mase.GetLength(1); y++)
        {
            if (mase[with - 2, y].DistanceFromStart > furthest.DistanceFromStart) furthest = mase[with - 2, y];
            if (mase[0, y].DistanceFromStart > furthest.DistanceFromStart) furthest = mase[0, y];
        }

        if (furthest.X == 0) furthest.left = false;
        else if (furthest.Y == 0) furthest.down= false;
        else if (furthest.X == with - 2) mase[furthest.X + 1, furthest.Y].left = false;
        else if (furthest.Y == helig - 2) mase[furthest.X, furthest.Y + 1].down= false;

        return new Vector2Int(furthest.X, furthest.Y);
    }
}
public class generatormazecell
{
    public int X, Y, DistanceFromStart;
    public bool left = true, down = true, Visited = false;

}
public class meaze : MonoBehaviour
{
    public GameObject cell;
    public int Width = 10;
    public int Height = 10;
    // Start is called before the first frame update
    void Start()
    {
        generatormaze gen = new generatormaze();
        generatormazecell[,] mase = gen.generatoratemaze();
        for (int x = 0; x < mase.GetLength(0); x++)
        {
            for (int y = 0; y < mase.GetLength(1); y++)
            {
                mazecell mc = Instantiate(cell, new Vector3(x*100, y * 100,0),Quaternion.identity).GetComponent<mazecell>();
                mc.down.SetActive(mase[x, y].down);
                mc.left.SetActive(mase[x, y].left);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RemoveWall(generatormazecell a, generatormazecell b)
    {
        if (a.X == b.X)
        {
            if (a.Y > b.Y) a.down = false;
            else b.down = false;
        }
        else
        {
            if (a.X > b.X) a.left = false;
            else b.left = false;
        }
    }
    private Vector2Int PlaceMazeExit(generatormazecell[,] maze)
    {
        generatormazecell furthest = maze[0, 0];

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            if (maze[x, Height - 2].DistanceFromStart > furthest.DistanceFromStart) furthest = maze[x, Height - 2];
            if (maze[x, 0].DistanceFromStart > furthest.DistanceFromStart) furthest = maze[x, 0];
        }

        for (int y = 0; y < maze.GetLength(1); y++)
        {
            if (maze[Width - 2, y].DistanceFromStart > furthest.DistanceFromStart) furthest = maze[Width - 2, y];
            if (maze[0, y].DistanceFromStart > furthest.DistanceFromStart) furthest = maze[0, y];
        }

        if (furthest.X == 0) furthest.left = false;
        else if (furthest.Y == 0) furthest.down = false;
        else if (furthest.X == Width - 2) maze[furthest.X + 1, furthest.Y].left = false;
        else if (furthest.Y == Height - 2) maze[furthest.X, furthest.Y + 1].down = false;

        return new Vector2Int(furthest.X, furthest.Y);
    }
}
