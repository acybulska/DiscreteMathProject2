using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject2
{
    public class Edge
    {
        public int value { get; set; }
        public int vertex1 { get; set; }
        public int vertex2 { get; set; }

        public int size;
        public int[,] edges;

        public Edge(int size)
        {
            this.size = size;
            edges = new int[size, size];
            for(int i=0;i<size;++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    edges[i, j] = 0;
                }
            }

        }
    }
}
