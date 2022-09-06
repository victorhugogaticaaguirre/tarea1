using System;


using OpenTK;
using OpenTK.Graphics.OpenGL;
//using OpenTK.Graphics.ES11;


namespace tarea1
{
     class Game
    {
        GameWindow window;

       public Game(GameWindow window)
        {
            this.window = window;
            start();
        }


        void start()
        {
            window.Load += loaded;
            window.Resize += resize; 
            window.RenderFrame += renderF;
            window.Run(1.0/60.0);
        }

        void resize(object o, EventArgs e)
        {
            GL.Viewport(0,0,window.Width,window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho((float)0.0, (float)50.0, (float)0.0, (float)50.0, (float)-1.0, (float)1.0);
            GL.MatrixMode(MatrixMode.Modelview);

        }

        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Triangles);
             GL.Vertex2(1.0,1.0);
             GL.Vertex2(49.0, 1.0);
             GL.Vertex2(25.0, 49.0);
            GL.Color3(1.0f, 0, 1.0f);
            GL.End();
            
            window.SwapBuffers();
        }
        void loaded( object o,EventArgs e)
        {
            
            GL.ClearColor(1.0f, 0.0f, 0.0f, 0.0f);
        }
       

    }
}
