using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasGeometria.Models
{
    class Circulo : Figura 
    {        
        const double PI = 3.14159;
        public double Radio { get; set; }

        public override double GetArea()
        {
            return (double)(PI * Math.Pow(this.Radio , 2));
        }
    }
}
