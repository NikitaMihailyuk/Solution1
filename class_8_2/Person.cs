using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8_2
{

    /// <summary>
    /// idoable delet new and nasledovanite na class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Person<T, K> where T : class, new()
        where  K : class
    {
        public static T Value { get; set; }
        public static K Value1 { get; set; }
    }
}
