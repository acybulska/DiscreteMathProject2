using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject2
{
    class Graph<T>
    {
        private static int size;
        private List<Vertex> vertices=new List<Vertex>(size);
        private List<Edge>  edges =new List<Edge>();

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
                vertex.data = rnd.Next(1, 101);
                vertex.index = i;
                i++;
            }
        }

        public void SetEdges()
        {
            Random rnd = new Random();
            foreach (var vertex in vertices)
            {
                int edgesNumber = rnd.Next(1,Convert.ToInt32(0.1*size));
                for (int i = 0; i < edgesNumber; ++i)
                {
                    
                }
            }
        }

        public void CreateGraph()
        {
            
        }
    }
}
