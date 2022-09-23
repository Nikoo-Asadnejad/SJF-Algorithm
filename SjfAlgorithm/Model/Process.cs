using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjfAlgorithm.Model
{
    public class Process
    {
        public string Name { get; set; }
        public int ProcessTime { get; set; }

        public Process()
        {

        }
        public Process(string name , int processTime)
        {
            Name = name;
            ProcessTime = processTime;  
        }

    }
}
