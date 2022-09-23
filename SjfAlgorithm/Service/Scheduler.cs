using SjfAlgorithm.Interface;
using SjfAlgorithm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjfAlgorithm.Service
{
    public class Scheduler : IScheduler
    {
        
        public async Task ExecuteProcesses(IList<Process> processList)
        {
            
           IOrderedEnumerable<Process> orderedProcess =  OrderProcesses(processList).Result;

            foreach (Process process in orderedProcess)
            {
                await Write(process);
            }
             
            
        }

       
    
        private async Task<IOrderedEnumerable<Process>> OrderProcesses(IEnumerable<Process> processList)
        => processList.OrderBy(x => x.ProcessTime);
        
        private async Task Write(Process process)
        {
            Console.WriteLine();
            Console.WriteLine($"Process {process.Name.ToUpper()} is Executed , Execution Time Was : {process.ProcessTime}");
            //  Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
           
        }
         
    }
}
