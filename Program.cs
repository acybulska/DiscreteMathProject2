﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(100);
            graph.SetVertices();
            graph.SetEdges();
        }
    }
}
