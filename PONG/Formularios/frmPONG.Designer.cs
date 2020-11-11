namespace PONG.Formularios
{
    partial class frmPONG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.objBola = new System.Windows.Forms.PictureBox();
            this.objPaletaBot = new System.Windows.Forms.PictureBox();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.ScoreShow = new System.Windows.Forms.PictureBox();
            this.contBorde2 = new System.Windows.Forms.PictureBox();
            this.objPaletaJgdr = new System.Windows.Forms.PictureBox();
            this.timJuego = new System.Windows.Forms.Timer(this.components);
            this.lblPuntosJgdr = new System.Windows.Forms.Label();
            this.lblPuntosBot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objPaletaBot)).BeginInit();
            this.pnlJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBorde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objPaletaJgdr)).BeginInit();
            this.SuspendLayout();
            // 
            // objBola
            // 
            this.objBola.Image = global::PONG.Properties.Resources.img_bola;
            this.objBola.Location = new System.Drawing.Point(384, 352);
            this.objBola.Name = "objBola";
            this.objBola.Size = new System.Drawing.Size(16, 16);
            this.objBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.objBola.TabIndex = 0;
            this.objBola.TabStop = false;
            // 
            // objPaletaBot
            // 
            this.objPaletaBot.Image = global::PONG.Properties.Resources.img_paleta;
            this.objPaletaBot.Location = new System.Drawing.Point(720, 336);
            this.objPaletaBot.Name = "objPaletaBot";
            this.objPaletaBot.Size = new System.Drawing.Size(16, 64);
            this.objPaletaBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.objPaletaBot.TabIndex = 1;
            this.objPaletaBot.TabStop = false;
            // 
            // pnlJuego
            // 
            this.pnlJuego.Controls.Add(this.objPaletaJgdr);
            this.pnlJuego.Controls.Add(this.objPaletaBot);
            this.pnlJuego.Controls.Add(this.objBola);
            this.pnlJuego.Controls.Add(this.ScoreShow);
            this.pnlJuego.Controls.Add(this.contBorde2);
            this.pnlJuego.Controls.Add(this.lblPuntosBot);
            this.pnlJuego.Controls.Add(this.lblPuntosJgdr);
            this.pnlJuego.Location = new System.Drawing.Point(0, 0);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(768, 768);
            this.pnlJuego.TabIndex = 3;
            // 
            // ScoreShow
            // 
            this.ScoreShow.BackColor = System.Drawing.Color.Transparent;
            this.ScoreShow.Location = new System.Drawing.Point(0, -96);
            this.ScoreShow.Name = "ScoreShow";
            this.ScoreShow.Size = new System.Drawing.Size(768, 82);
            this.ScoreShow.TabIndex = 4;
            this.ScoreShow.TabStop = false;
            // 
            // contBorde2
            // 
            this.contBorde2.BackColor = System.Drawing.Color.White;
            this.contBorde2.Location = new System.Drawing.Point(0, 768);
            this.contBorde2.Name = "contBorde2";
            this.contBorde2.Size = new System.Drawing.Size(768, 82);
            this.contBorde2.TabIndex = 3;
            this.contBorde2.TabStop = false;
            // 
            // objPaletaJgdr
            // 
            this.objPaletaJgdr.Image = global::PONG.Properties.Resources.img_paleta;
            this.objPaletaJgdr.Location = new System.Drawing.Point(32, 336);
            this.objPaletaJgdr.Name = "objPaletaJgdr";
            this.objPaletaJgdr.Size = new System.Drawing.Size(16, 64);
            this.objPaletaJgdr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.objPaletaJgdr.TabIndex = 2;
            this.objPaletaJgdr.TabStop = false;
            // 
            // timJuego
            // 
            this.timJuego.Enabled = true;
            this.timJuego.Interval = 1;
            this.timJuego.Tick += new System.EventHandler(this.timJuego_Tick);
            // 
            // lblPuntosJgdr
            // 
            this.lblPuntosJgdr.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosJgdr.Font = new System.Drawing.Font("Rubik", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosJgdr.ForeColor = System.Drawing.Color.White;
            this.lblPuntosJgdr.Location = new System.Drawing.Point(32, 32);
            this.lblPuntosJgdr.Name = "lblPuntosJgdr";
            this.lblPuntosJgdr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPuntosJgdr.Size = new System.Drawing.Size(336, 160);
            this.lblPuntosJgdr.TabIndex = 5;
            this.lblPuntosJgdr.Text = "0";
            // 
            // lblPuntosBot
            // 
            this.lblPuntosBot.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosBot.Font = new System.Drawing.Font("Rubik", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosBot.ForeColor = System.Drawing.Color.White;
            this.lblPuntosBot.Location = new System.Drawing.Point(400, 32);
            this.lblPuntosBot.Name = "lblPuntosBot";
            this.lblPuntosBot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPuntosBot.Size = new System.Drawing.Size(336, 160);
            this.lblPuntosBot.TabIndex = 6;
            this.lblPuntosBot.Text = "0";
            // 
            // frmPONG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(768, 768);
            this.Controls.Add(this.pnlJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPONG";
            this.Load += new System.EventHandler(this.frmPONG_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPONG_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.objBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objPaletaBot)).EndInit();
            this.pnlJuego.ResumeLayout(false);
            this.pnlJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBorde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objPaletaJgdr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox objBola;
        private System.Windows.Forms.PictureBox objPaletaBot;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Timer timJuego;
        private System.Windows.Forms.PictureBox objPaletaJgdr;
        private System.Windows.Forms.PictureBox ScoreShow;
        private System.Windows.Forms.PictureBox contBorde2;
        private System.Windows.Forms.Label lblPuntosBot;
        private System.Windows.Forms.Label lblPuntosJgdr;
    }
}