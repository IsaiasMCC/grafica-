using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafica.Models
{
    public interface IObjeto
    {
        void Dibujar();
        void Rotar(double angle, double x, double y, double z);
        void Trasladar(double x, double y, double z);
        void Escalar(double x, double y, double z); 
    }
}
