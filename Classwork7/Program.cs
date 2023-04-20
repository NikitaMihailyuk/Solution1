using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork7
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }//// 3 классa / из файла. базы данных. апи;

            /// консоль или почта
            public void ProcessData(IDataProvider provider, IDataProcessor processor)
            {
                processor.DisplayData(provider);
            }

      
    }
}
