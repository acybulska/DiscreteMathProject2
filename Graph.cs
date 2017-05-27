using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject2
{
    public class Graph<T>
    {
        private static int size;
        private List<Vertex> vertices=new List<Vertex>(size);
        public Edge edges = new Edge(size);


        public void SetSize()
        {
            size = 100;
        }

        public void SetVertices()
        {
            Random rnd = new Random();
            int i = 0;
            foreach (var vertex in vertices)
            {
                vertex.value = rnd.Next(1, 101); // Vertex's value is between 1 and 100
                vertex.edgesNumber = rnd.Next(1, Convert.ToInt32(0.1 * size)); // amount of edges connecting each vertex
                vertex.index = i;
                ++i;
            }
        }

        public void SetEdges()
        {
            Random rnd = new Random();

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < vertices[i].edgesNumber; ++j)
                {
                    int vertex = rnd.Next(i + 1, size);
                    if (edges.edges[i, vertex] == 0)
                    {
                        if (vertices[vertex].edgesSet <= vertices[vertex].edgesNumber)
                        {
                            edges.edges[i, vertex] = rnd.Next(1, 101);
                            edges.edges[vertex, i] = edges.edges[i, vertex];
                        }
                    }

                }
            }
        }

        public void CreateGraph()
        {
            
        }
    }
}
