using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork7
{
    public class ConsoleDataProcessor : IDataProcessor
    {
        public void  DisplayData(IDataProvider provider)
        {
            string data = provider.GetData();
            Console.WriteLine(data);
        }
    }
}
