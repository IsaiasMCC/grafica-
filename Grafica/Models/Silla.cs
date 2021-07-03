using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Grafica.Models
{
    class Silla : Objeto
    {

        private double dx;
        private double dy;
        private double dz;

        public Silla(double dx, double dy, double dz, double cx, double cy, double cz) : base(cx, cy, cz)
        {
            this.dx = dx;
            this.dy = dy;
            this.dz = dz;

            partes.Add("asiento", new Parte(dx, dy*0.1 , dz, cx, cy, cz,1.0f, 0.0f, 1.0f));
            partes.Add("pata1", new Parte(dx * 0.2, dy * 0.5, dz * 0.2, cx-(dx/2), cy - ((dy/2)+ dy * 0.1), cz-(dx/2) , 1.0f, 0.0f, 0.0f));
            partes.Add("pata2", new Parte(dx * 0.2, dy * 0.5, dz * 0.2, cx +(dx/2), cy - ((dy /2)+ dy * 0.1), cz-(dx/2) , 1.0f, 0.0f, 0.0f));

            partes.Add("pata3", new Parte(dx * 0.2, dy * 0.5, dz * 0.2, cx + (dx / 2), cy - ((dy / 2)+ dy * 0.1), cz + (dx/2), 1.0f, 0.0f, 0.0f));
            partes.Add("pata4", new Parte(dx * 0.2, dy * 0.5, dz * 0.2, cx - (dx /2), cy - ((dy / 2)+ dy * 0.1), cz + (dx/2 ), 1.0f, 0.0f, 0.0f));

            partes.Add("apollo", new Parte(dx , dy/2, dz * 0.2, cx, cy + ((dy / 2)+ dy * 0.1), cz + (dx-(dy*0.1)), 1.0f, 1.0f, 0.0f));
           
        }
       

    }
}
