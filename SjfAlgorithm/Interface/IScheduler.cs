using SjfAlgorithm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjfAlgorithm.Interface
{
    public interface IScheduler 
    {
         Task ExecuteProcesses(IList<Process> processList);
    }
}
