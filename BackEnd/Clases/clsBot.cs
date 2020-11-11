using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BackEnd.Clases
{
    public class clsBot
    {
        public clsBot()
        {

        }

        #region Instanciar_Objetos
        /* INSTANCIÓN */

        Random random = new Random();
        #endregion



        #region Variables
        /* VARIABLES */

        public int X;
        public int Y;

        public int Vvel;
        public int MinVel;
        public int MaxVel;
        #endregion



        #region Métodos
        /* MÉTODOS */
        public void BotMovimiento(PictureBox img, PictureBox bola, Panel panel, int azar)
        {
            // Actualización de posición
            X = img.Location.X;
            Y = img.Location.Y;

            if (bola.Location.X < img.Location.X)
            {
                switch(azar)
                {
                    // Activo
                    case 0:
                        if (Y + 32 < bola.Location.Y)
                        {
                            Vvel = 8;
                        }
                        
                        else
                        {
                            Vvel = -8;
                        }
                        break;

                    // Pasivo
                    case 1:
                        if (Y < panel.Location.Y)
                        {
                            Vvel = 3;
                        }

                        else if (Y + img.Height > panel.Location.Y + panel.Height)
                        {
                            Vvel = -3;
                        }
                        break;
                }
            }

            else
            {
                Vvel = 0;
            }

            // Mover bola a la posición nueva
            img.Location = new Point(X, Y + Vvel);
        }
        #endregion
    }
}
