namespace CapaPresentacion
{
    partial class frmRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutas));
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tablaRuta = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRuta)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.White;
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(819, 278);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(374, 31);
            this.txtRuta.TabIndex = 61;
            this.txtRuta.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(808, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(398, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(814, 249);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(44, 20);
            this.lblRuta.TabIndex = 56;
            this.lblRuta.Text = "Ruta";
            this.lblRuta.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(627, 513);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(151, 59);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(229, 513);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(151, 59);
            this.btnEditar.TabIndex = 54;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.BorderRadius = 0;
            this.btnBorrar.ButtonText = "Borrar";
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Iconimage")));
            this.btnBorrar.Iconimage_right = null;
            this.btnBorrar.Iconimage_right_Selected = null;
            this.btnBorrar.Iconimage_Selected = null;
            this.btnBorrar.IconMarginLeft = 0;
            this.btnBorrar.IconMarginRight = 0;
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconRightZoom = 0D;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.IconZoom = 90D;
            this.btnBorrar.IsTab = false;
            this.btnBorrar.Location = new System.Drawing.Point(430, 513);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBorrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBorrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrar.selected = false;
            this.btnBorrar.Size = new System.Drawing.Size(151, 59);
            this.btnBorrar.TabIndex = 52;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrar.Textcolor = System.Drawing.Color.White;
            this.btnBorrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.BorderRadius = 0;
            this.btnCreate.ButtonText = "Agregar";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreate.Iconimage")));
            this.btnCreate.Iconimage_right = null;
            this.btnCreate.Iconimage_right_Selected = null;
            this.btnCreate.Iconimage_Selected = null;
            this.btnCreate.IconMarginLeft = 0;
            this.btnCreate.IconMarginRight = 0;
            this.btnCreate.IconRightVisible = true;
            this.btnCreate.IconRightZoom = 0D;
            this.btnCreate.IconVisible = true;
            this.btnCreate.IconZoom = 90D;
            this.btnCreate.IsTab = false;
            this.btnCreate.Location = new System.Drawing.Point(35, 513);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreate.selected = false;
            this.btnCreate.Size = new System.Drawing.Size(151, 59);
            this.btnCreate.TabIndex = 51;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Textcolor = System.Drawing.Color.White;
            this.btnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tablaRuta
            // 
            this.tablaRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRuta.Location = new System.Drawing.Point(35, 249);
            this.tablaRuta.Name = "tablaRuta";
            this.tablaRuta.RowHeadersWidth = 51;
            this.tablaRuta.RowTemplate.Height = 24;
            this.tablaRuta.Size = new System.Drawing.Size(743, 227);
            this.tablaRuta.TabIndex = 53;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(35, 155);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(423, 52);
            this.txtBuscar.TabIndex = 50;
            this.txtBuscar.text = "";
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.btnAtras);
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1259, 87);
            this.pnlTop.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1166, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rutas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(1085, 14);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(65, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 3;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 579);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tablaRuta);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRutas";
            this.Text = "frmRutas";
            this.Load += new System.EventHandler(this.frmRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRuta)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private System.Windows.Forms.DataGridView tablaRuta;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox btnAtras;
    }
}