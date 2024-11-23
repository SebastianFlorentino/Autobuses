namespace CapaPresentacion
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAutobus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 87);
            this.pnlTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Contextual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(725, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(52, 50);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.pnlTop;
            this.moverFormulario.Vertical = true;
            // 
            // btnChofer
            // 
            this.btnChofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChofer.BorderRadius = 0;
            this.btnChofer.ButtonText = "Chofer";
            this.btnChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChofer.DisabledColor = System.Drawing.Color.Gray;
            this.btnChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChofer.Iconimage")));
            this.btnChofer.Iconimage_right = null;
            this.btnChofer.Iconimage_right_Selected = null;
            this.btnChofer.Iconimage_Selected = null;
            this.btnChofer.IconMarginLeft = 0;
            this.btnChofer.IconMarginRight = 0;
            this.btnChofer.IconRightVisible = true;
            this.btnChofer.IconRightZoom = 0D;
            this.btnChofer.IconVisible = true;
            this.btnChofer.IconZoom = 90D;
            this.btnChofer.IsTab = false;
            this.btnChofer.Location = new System.Drawing.Point(265, 146);
            this.btnChofer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChofer.selected = false;
            this.btnChofer.Size = new System.Drawing.Size(244, 59);
            this.btnChofer.TabIndex = 2;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChofer.Textcolor = System.Drawing.Color.White;
            this.btnChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // btnAutobus
            // 
            this.btnAutobus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutobus.BorderRadius = 0;
            this.btnAutobus.ButtonText = "Autobus";
            this.btnAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutobus.DisabledColor = System.Drawing.Color.Gray;
            this.btnAutobus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAutobus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAutobus.Iconimage")));
            this.btnAutobus.Iconimage_right = null;
            this.btnAutobus.Iconimage_right_Selected = null;
            this.btnAutobus.Iconimage_Selected = null;
            this.btnAutobus.IconMarginLeft = 0;
            this.btnAutobus.IconMarginRight = 0;
            this.btnAutobus.IconRightVisible = true;
            this.btnAutobus.IconRightZoom = 0D;
            this.btnAutobus.IconVisible = true;
            this.btnAutobus.IconZoom = 90D;
            this.btnAutobus.IsTab = false;
            this.btnAutobus.Location = new System.Drawing.Point(265, 213);
            this.btnAutobus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAutobus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAutobus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAutobus.selected = false;
            this.btnAutobus.Size = new System.Drawing.Size(244, 59);
            this.btnAutobus.TabIndex = 3;
            this.btnAutobus.Text = "Autobus";
            this.btnAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutobus.Textcolor = System.Drawing.Color.White;
            this.btnAutobus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRuta.BorderRadius = 0;
            this.btnRuta.ButtonText = "Ruta";
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btnRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRuta.Iconimage")));
            this.btnRuta.Iconimage_right = null;
            this.btnRuta.Iconimage_right_Selected = null;
            this.btnRuta.Iconimage_Selected = null;
            this.btnRuta.IconMarginLeft = 0;
            this.btnRuta.IconMarginRight = 0;
            this.btnRuta.IconRightVisible = true;
            this.btnRuta.IconRightZoom = 0D;
            this.btnRuta.IconVisible = true;
            this.btnRuta.IconZoom = 90D;
            this.btnRuta.IsTab = false;
            this.btnRuta.Location = new System.Drawing.Point(265, 280);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRuta.selected = false;
            this.btnRuta.Size = new System.Drawing.Size(244, 59);
            this.btnRuta.TabIndex = 4;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRuta.Textcolor = System.Drawing.Color.White;
            this.btnRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnAutobus);
            this.Controls.Add(this.btnChofer);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Main";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        private Bunifu.Framework.UI.BunifuFlatButton btnChofer;
        private Bunifu.Framework.UI.BunifuFlatButton btnAutobus;
        private Bunifu.Framework.UI.BunifuFlatButton btnRuta;
    }
}