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
            FileDataProvider provider1 = new FileDataProvider();
            MailDataProcessor mailDataProcessor = new MailDataProcessor();

            ProcessData(provider1, mailDataProcessor);
        }//// 3 классa / из файла. базы данных. апи;

            /// консоль или почта
            static void ProcessData(IDataProvider provider, IDataProcessor processor)
            {
            string data = provider.GetData();   
            processor.DisplayData(provider);
            }

      
    }
}
