using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

namespace DFSExample
{
    public class Graph
    {
        private int vertices;

        private List<int>[] adjList;

        public Graph(int v)
        {
            vertices = v;

            adjList = new List<int>[v];

            for (int i = 0; i < v; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        public void AddEdge(int c, int v)
        {
            adjList[c].Add(v);
        }

        public void DFS(int v)
        {
            bool[] visited = new bool[vertices];
            
            Stack<int> stack = new Stack<int>();
            
            visited[v] = true;
            
            stack.Push(v);

            while (stack.Count != 0)
            {
                v = stack.Pop();
                Debug.Log($"Next -> {v}");
                foreach (int i in adjList[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
    }
}