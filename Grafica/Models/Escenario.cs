using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Grafica.Models
{
    public  class Escenario: IObjeto
    {
        protected double centroX;
        protected double centroY;
        protected double centroZ;
         Dictionary<string, Objeto> listaObjeto;

        public Escenario(double centroX, double centroY, double centroZ)
        {
            this.centroX = centroX;
            this.centroY = centroY;
            this.centroZ = centroZ;
            listaObjeto = new Dictionary<string, Objeto>(); 
        }
        public void add(string key, Objeto value )
        {
            listaObjeto.Add(key, value);
        }

        public Objeto get(string key)
        {
            Objeto value = null;
            foreach (KeyValuePair<string, Objeto> obj in listaObjeto)
            {
                if (key == obj.Key)
                    value = obj.Value;
            }
            return value;
        }
        public void Dibujar()
        {  
            foreach (KeyValuePair<string,Objeto> obj in listaObjeto)
            {
                obj.Value.Dibujar();
            }
            GL.PopMatrix();
        } 
        public void Rotar(double angle, double x, double y, double z)
        {

            GL.PushMatrix();
            foreach (KeyValuePair<string, Objeto> obj in listaObjeto)
            {
              
                obj.Value.Rotar(angle, x, y, z);
              
            }


        }

        public void Escalar(double x, double y, double z)
        {
            foreach(KeyValuePair<string, Objeto> obj in listaObjeto)
            {
                obj.Value.Escalar(x, y, z);
            }
        }

        public void Trasladar( double x, double y, double z)
        {
            foreach( KeyValuePair<string, Objeto> obj in listaObjeto)
            {
                obj.Value.Trasladar(x, y, z);
            }
        }
    }
}
