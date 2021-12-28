using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DFSExample
{
    public class DFSCommander : MonoBehaviour
    {
        private void Start()
        {
            Graph graph = new Graph(6);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(3, 5);
            graph.AddEdge(5, 4);
            graph.DFS(1);
        }
    }
}