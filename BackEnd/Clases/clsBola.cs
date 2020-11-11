using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace BackEnd.Clases
{
    public class clsBola
    {
        public clsBola()
        {
            Vvel    = 4;
            Hvel    = -4;
            MinVvel = 3;
            MaxVvel = 6;
            MinHvel = 4;
            MaxHvel = 11;

            PuntosJugador = 0;
            PuntosBot     = 0;
        }

        #region Instanciar_Objetos
        /* INSTANCIÓN */

        Random random = new Random();
        #endregion



        #region Variables
        /* VARIABLES */

        public int X;
        public int Y;

        public int Hvel;
        public int Vvel;
        public int MinVvel;
        public int MaxVvel;
        public int MinHvel;
        public int MaxHvel;

        public int Caja_Arriba;
        public int Caja_Abajo;
        public int Caja_Derecha;
        public int Caja_Izquierda;

        public int PuntosJugador;
        public int PuntosBot;
        #endregion



        #region Métodos
        /* MÉTODOS */

        public void BolaMovimiento(PictureBox img, Panel panel)
        {
            // Actualización de posición
            X = img.Location.X;
            Y = img.Location.Y;

            Caja_Arriba    = Y;
            Caja_Abajo     = Y + img.Height;
            Caja_Derecha   = X + img.Width;
            Caja_Izquierda = X;

            #region Colisiones
            foreach (Control obj in panel.Controls)
            {
                // Paletas
                if (obj is PictureBox)
                {
                    if (obj != img)
                    {
                        /* EJE X */
                        if
                              ((Caja_Arriba    >= obj.Location.Y && Caja_Arriba <= obj.Location.Y + obj.Height
                            ||  Caja_Abajo     >= obj.Location.Y && Caja_Abajo  <= obj.Location.Y + obj.Height)
                            && (Caja_Derecha   >= obj.Location.X - Hvel
                            &&  Caja_Izquierda <= obj.Location.X + obj.Width + (Hvel * -1)))
                        {
                            if (Hvel > 0)
                            {
                                X = obj.Location.X - img.Width - 1;
                            }

                            if (Hvel < 0)
                            {
                                X = obj.Location.X + obj.Width + 1;
                            }

                            // Aplica un entero aleatorio
                            Hvel = (Math.Sign(Hvel) * -1) * random.Next(MinHvel, MaxHvel);
                            Vvel = (Math.Sign(Vvel) * -1) * random.Next(MinVvel, MaxVvel);
                        }

                        /* EJE Y */
                        if
                                ((Caja_Izquierda >= obj.Location.X && Caja_Izquierda <= obj.Location.X + obj.Width
                              ||  Caja_Derecha   >= obj.Location.X && Caja_Derecha   <= obj.Location.X + obj.Width)
                              && (Caja_Abajo     >= obj.Location.Y - Vvel
                              &&  Caja_Arriba    <= obj.Location.Y + obj.Height + (Vvel * -1)))
                        {
                            if (Vvel > 0)
                            {
                                Y = obj.Location.Y - img.Height - 1;
                            }

                            if (Vvel < 0)
                            {
                                Y = obj.Location.Y + obj.Height + 1;
                            }

                            Vvel = Vvel * -1;
                        }
                    }
                }
            }

            if (Caja_Izquierda > panel.Location.X + panel.Width || Caja_Derecha < panel.Location.X)
            {
                if (Hvel < 0)
                {
                    PuntosBot++;
                }

                else
                {
                    PuntosJugador++;
                }

                X = (panel.Location.X + panel.Width)  / 2;
                Y = (panel.Location.Y + panel.Height) / 2;
            }
            #endregion

            // Mover bola a la posición nueva
            img.Location = new Point(X + Hvel, Y + Vvel);
        }
        #endregion
    }
}
