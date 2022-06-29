using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasGeometria.Models
{
    class Rectangulo : Figura 
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double GetArea()
        {
            return (this.Base * this.Altura);
        }
    }
}
