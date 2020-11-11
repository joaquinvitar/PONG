using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using BackEnd.Clases;

namespace BackEnd
{
    public class clsJugador
    {
        public clsJugador()
        {

        }

        #region Variables
        /* VARIABLES */

        public int X;
        public int Y;
        #endregion



        #region Métodos
        /* MÉTODOS */

        public void JgdrMovimiento(PictureBox img, Form form) // JUGADOR
        {
            // Actualización de posición
            X = img.Location.X;
            Y = (Cursor.Position.Y - form.Location.Y) - (img.Height / 2);

            img.Location = new Point(X, Y);
        }
        #endregion
    }
}
