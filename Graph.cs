using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject2
{
    public class Graph
    {
        private int size;
        private List<Vertex> vertices;
        //public Edge edges = new Edge(size);
        public int[,] edges;

        public Graph(int size)
        {
            this.size = size;
            vertices = new List<Vertex>(size);
            edges = new int[size, size];
        }

        public void SetVertices()
        {
            Random rnd = new Random();
            Random rnd2=new Random();
            int i = 0;
            foreach (var vertex in vertices)
            {
                vertex.value = rnd.Next(1, 101); // Vertex's value is between 1 and 100
                vertex.edgesSet = 0;
                int no = Convert.ToInt32(0.1 * size);
                vertex.edgesNumber = rnd2.Next(1, no); // amount of edges connecting each vertex
                vertex.index = i;
                ++i;
                Console.WriteLine("Vertex value = {0}, edges number = {1}", vertex.value, vertex.edgesNumber);
            }
        }

        public void SetEdges()
        {
            Random rnd = new Random();

            for (int i = 0; i < size; i++) // po kolumnach tablicy
            {
                while (vertices[i].edgesSet == vertices[i].edgesNumber)
                {
                    int vertex = rnd.Next(i + 1, size); // losowy wierzchołek wiersza

                    if (vertices[vertex].edgesSet < vertices[vertex].edgesNumber)
                    {
                        if (edges[i, vertex] == 0)
                        {
                            edges[i, vertex] = rnd.Next(1, 101);
                            edges[vertex, i] = edges[i, vertex];
                            vertices[vertex].edgesSet++;
                            vertices[i].edgesSet++;
                        }
                    }
                    Console.WriteLine("Vertex1 = {0}, vertex2 = {1}, value set = {3}",i,vertex,edges[i,vertex]);
                }
            }
        }

        public void CreateGraph()
        {
            //SetVertices();
            
            //SetEdges();
            Console.ReadKey();
        }
    }
}
