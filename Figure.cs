using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_figures
{
    public abstract class Figure
    {
        private string name;
        public Figure(string name)
        {
            this.name = name;
        }   

        public abstract double Area();
    }
}
