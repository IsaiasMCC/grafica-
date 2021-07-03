using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
namespace Grafica.Models
{
    public class Game : GameWindow  
    {
        private Escenario escena;
        double teta=0.0;
        public Game(int width, int height, string title)
        {
            this.Width = width;
            this.Height = height;
            this.Title = title;
            instanciar();
            Run(60);
        }
        public void instanciar()
        {
            escena = new Escenario(0.5,0.5,0.5);
            escena.add("silla1",new Silla(0.25, 0.65, 0.25, 0.5, 0.01, 0.6));
            escena.add("silla2", new Silla(0.15, 0.40, 0.15, -0.5, 0.5, 0.5));
            escena.add("silla3", new Silla(0.05, 0.26, 0.05, 0.1, -0.5, 0.1));

        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.PushMatrix();
           //   escena.Trasladar(0.5,0.5,0.5);
         
           // escena.get("silla1").Rotar(teta,0.0,1.0,0.0);
           // escena.get("silla1").Dibujar();
            //escena.get("silla2").Rotar(teta, 0.0, 0.1, 0.0);
          //  escena.get("silla2").Dibujar();
            
         
            // escena.get("silla3").getParte("pata1").Rotar(teta, 0.0, 0.1, 0.0);
             // escena.get("silla3").getParte("pata1").Dibujar();

            
            escena.Rotar(teta,0.0,0.1,0.0);
            escena.Dibujar();
            
            teta = teta + 0.1;
            
            GL.PopMatrix();
            Context.SwapBuffers();
            base.OnRenderFrame(e);

        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
        }
    }
}
