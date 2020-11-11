using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;
using BackEnd.Clases;

namespace PONG.Formularios
{
    public partial class frmPONG : Form
    {
        public frmPONG()
        {
            InitializeComponent();
        }

        #region Instanciar_Objetos
        /* INSTANCIÓN */

        clsJugador Jugador = new clsJugador();
        clsBot     Bot     = new clsBot();
        clsBola    Bola    = new clsBola();
        Random     random  = new Random();
        #endregion



        #region Variables
        /* VARIABLES */

        public int i;
        public int azar;
        public int azar2;
        public int posLista;
        #endregion

        private void frmPONG_Load(object sender, EventArgs e)
        {
            i = 0;

            azar  = random.Next(0, 2);
            azar2 = random.Next(40, 80);

            timJuego.Enabled = false;
        }



        #region Timers
        /* TIMERS */

        private void timJuego_Tick(object sender, EventArgs e)
        {
            Jugador.JgdrMovimiento(objPaletaJgdr, this);
            Bola.BolaMovimiento(objBola, pnlJuego);
            Bot.BotMovimiento(objPaletaBot, objBola, pnlJuego, azar);

            this.Refresh(); // Actualiza el formulario

            i++;

            if (i >= azar2)
            {
                azar = random.Next(0, 2);
                i = 0;
                azar2 = random.Next(40, 80);
            }

            lblPuntosJgdr.Text = Convert.ToString(Bola.PuntosJugador);
            lblPuntosBot.Text  = Convert.ToString(Bola.PuntosBot);
        }
        #endregion



        #region Evento_Presionar
        /* PRESIONAR */

        private void frmPONG_KeyDown(object sender, KeyEventArgs e)
        {
            // Comienzo del juego
            if (pnlJuego.Visible == true && e.KeyCode == Keys.Space)
            {
                timJuego.Enabled = true;
            }

            // Cerrar juego
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
