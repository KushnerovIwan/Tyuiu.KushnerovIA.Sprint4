using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KushnerovIA.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            string[] mass = Array.FindAll(array, x => x.Length > 6);
            return mass.Length;
        }
    }
}
