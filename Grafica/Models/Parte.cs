using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK.Input;

namespace Grafica.Models
{
     public class Parte : IObjeto
    {
      
        
        protected double dx;
        protected double dy;
        protected double dz;

        protected double cx;
        protected double cy;
        protected double cz;
        protected double x, y, z;
      
        public Parte(double dx, double dy, double dz, double cx, double cy, double cz, double x,double y, double z)
        {
            this.dx = dx;
            this.dy = dy;
            this.dz = dz;

            this.cx = cx;
            this.cy = cy;
            this.cz = cz;

            this.x = x;
            this.y = y;
            this.z = z;
           
        }

        public void Dibujar()
        {

            dibujarParte();
          //  GL.PopMatrix();
        }

        public void Rotar(double angle, double x, double y, double z)
        {
           // GL.PushMatrix();
            GL.Rotate(angle, x, y, z);
         
        }

        public void Escalar(double x, double y, double z)
        {
            GL.Scale(x, y, z);
        }

        public void Trasladar(double x, double y, double z)
        {
            GL.Translate(x,y,z);
        }

        public void dibujarParte()
        {
           
            GL.Begin(BeginMode.Quads);
            GL.Color3(x, y, z);

            GL.Vertex3(cx - dx, cy - dy, cz - dz);
            GL.Vertex3(cx + dx, cy - dy, cz - dz);
            GL.Vertex3(cx + dx, cy + dy, cz - dz);
            GL.Vertex3(cx - dx, cy + dy, cz - dz);

            GL.End();

            GL.Begin(BeginMode.Quads);

            GL.Vertex3(cx - dx, cy - dy, cz - dz);
            GL.Vertex3(cx - dx, cy - dy, cz + dz);
            GL.Vertex3(cx - dx, cy + dy, cz + dz);
            GL.Vertex3(cx - dx, cy + dy, cz - dz);
            GL.End();

            GL.Begin(BeginMode.Quads);
            GL.Vertex3(cx - dx, cy - dy, cz - dz);
            GL.Vertex3(cx + dx, cy - dy, cz - dz);
            GL.Vertex3(cx + dx, cy - dy, cz + dz);
            GL.Vertex3(cx - dx, cy - dy, cz + dz);
            GL.End();

            GL.Begin(BeginMode.Quads);
            GL.Vertex3(cx + dx, cy - dy, cz - dz);
            GL.Vertex3(cx + dx, cy - dy, cz + dz);
            GL.Vertex3(cx + dx, cy + dy, cz + dz);
            GL.Vertex3(cx + dx, cy + dy, cz - dz);
            GL.End();


            GL.Begin(BeginMode.Quads);
            GL.Vertex3(cx - dx, cy + dy, cz - dz);
            GL.Vertex3(cx + dx, cy + dy, cz - dz);
            GL.Vertex3(cx + dx, cy + dy, cz + dz);
            GL.Vertex3(cx - dx, cy + dy, cz + dz);
            GL.End();

            GL.Begin(BeginMode.Quads);
            GL.Vertex3(cx - dx, cy - dy, cz + dz);
            GL.Vertex3(cx + dx, cy - dy, cz + dz);
            GL.Vertex3(cx + dx, cy + dy, cz + dz);
            GL.Vertex3(cx - dx, cy + dy, cz + dz);
            GL.End();
           
        }
        }
    }

