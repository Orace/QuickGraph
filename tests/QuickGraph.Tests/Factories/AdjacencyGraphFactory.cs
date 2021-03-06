// <copyright file="AdjacencyGraphFactory.cs" company="MSIT">Copyright © MSIT 2007</copyright>

using System;
using Microsoft.Pex.Framework;
using QuickGraph;
using System.Collections.Generic;

namespace QuickGraph
{
    public static partial class AdjacencyGraphFactory
    {
        [PexFactoryMethod(typeof(AdjacencyGraph<int, Edge<int>>))]
        public static AdjacencyGraph<int, Edge<int>> Create(
            bool allowParralelEdges,
            KeyValuePair<int, int>[] edges)
        {
            PexAssume.IsNotNull(edges);

            var adjacencyGraph
               = new AdjacencyGraph<int, Edge<int>>(allowParralelEdges);
            if(edges != null && edges.Length <= 3)
                foreach (var edge in edges)
                    adjacencyGraph.AddVerticesAndEdge(new Edge<int>(edge.Key, edge.Value));

            return adjacencyGraph;
        }
    }
}
