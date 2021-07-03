using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK.Input;
namespace Grafica.Models
{
     public abstract class Objeto : IObjeto
    {
        protected double centroX;
        protected double centroY;
        protected double centroZ;
        

        protected Dictionary<string, Parte> partes;
        
         protected Objeto(double x, double y, double z)
        {
            this.centroX = x;
            this.centroY = y;
            this.centroZ = z;
        
            this.partes = new Dictionary<string, Parte>();
        }

        public void setCentroX(double centroX)
        {
            this.centroX = centroX;
        }
        public void setCentroY(double centroY)
        {
            this.centroY = centroY;
        }
        public void setCentroZ(double centroZ)
        {
            this.centroZ = centroZ;
        }
        public double getCentroX()
        {
            return this.centroX;
        }
        public double getCentroY()
        {
            return this.centroY;
        }
        public double getCentroZ()
        {
            return this.centroZ;
        }

        public Parte getParte(string key)
        {
            Parte value= null;
            foreach(KeyValuePair<string, Parte> parte in partes)
            {
                if (key == parte.Key)
                    value = parte.Value;
            }
            return value;
        }

        public void Trasladar( double x, double y, double z)
        {
            foreach(KeyValuePair<string, Parte> parte in partes)
            {
                parte.Value.Trasladar(x , y , z);
            }
        }
       
        public  void Escalar(double x, double y, double z)
        {
            foreach(KeyValuePair<string, Parte> parte in partes)
            {
                parte.Value.Escalar(x, y, z);
            }
        }

        public  void Dibujar()
        {

            foreach (KeyValuePair<string, Parte> parte in partes)
            {
               
                parte.Value.Dibujar();
                
            }
            GL.PopMatrix();

        }
        public  void Rotar(double angle, double x, double y, double z)
        {
             GL.PushMatrix();
            foreach (KeyValuePair<string, Parte> parte in partes)
            {
                parte.Value.Rotar(angle, x, y, z);
            }

        }


    }
}
