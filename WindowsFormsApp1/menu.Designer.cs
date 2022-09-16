namespace WindowsFormsApp1
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btncursos = new System.Windows.Forms.Button();
            this.btnoferta = new System.Windows.Forms.Button();
            this.gbxinformacionPersonal = new System.Windows.Forms.GroupBox();
            this.bttnInfoPersonal = new System.Windows.Forms.Button();
            this.lnklblcerrarSesion = new System.Windows.Forms.LinkLabel();
            this.mA = new System.Windows.Forms.ToolTip(this.components);
            this.gbxinformacionPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncursos
            // 
            this.btncursos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncursos.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncursos.ForeColor = System.Drawing.Color.Black;
            this.btncursos.Location = new System.Drawing.Point(119, 34);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(95, 65);
            this.btncursos.TabIndex = 0;
            this.btncursos.Text = "Tus cursos";
            this.mA.SetToolTip(this.btncursos, "Historial académico de los cursos que has tomado o tienes activos. ");
            this.btncursos.UseVisualStyleBackColor = false;
            // 
            // btnoferta
            // 
            this.btnoferta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnoferta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoferta.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoferta.ForeColor = System.Drawing.Color.Black;
            this.btnoferta.Location = new System.Drawing.Point(18, 34);
            this.btnoferta.Name = "btnoferta";
            this.btnoferta.Size = new System.Drawing.Size(95, 65);
            this.btnoferta.TabIndex = 1;
            this.btnoferta.Text = "Oferta de Cursos";
            this.mA.SetToolTip(this.btnoferta, "Aquí encontraras la información sobre los cursos disponibles para ti.\r\n");
            this.btnoferta.UseVisualStyleBackColor = false;
            this.btnoferta.Click += new System.EventHandler(this.btnoferta_Click);
            // 
            // gbxinformacionPersonal
            // 
            this.gbxinformacionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxinformacionPersonal.Controls.Add(this.bttnInfoPersonal);
            this.gbxinformacionPersonal.Controls.Add(this.btnoferta);
            this.gbxinformacionPersonal.Controls.Add(this.btncursos);
            this.gbxinformacionPersonal.Location = new System.Drawing.Point(184, 118);
            this.gbxinformacionPersonal.Name = "gbxinformacionPersonal";
            this.gbxinformacionPersonal.Size = new System.Drawing.Size(235, 191);
            this.gbxinformacionPersonal.TabIndex = 2;
            this.gbxinformacionPersonal.TabStop = false;
            this.gbxinformacionPersonal.Text = "Opciones";
            // 
            // bttnInfoPersonal
            // 
            this.bttnInfoPersonal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnInfoPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnInfoPersonal.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInfoPersonal.ForeColor = System.Drawing.Color.Black;
            this.bttnInfoPersonal.Location = new System.Drawing.Point(77, 105);
            this.bttnInfoPersonal.Name = "bttnInfoPersonal";
            this.bttnInfoPersonal.Size = new System.Drawing.Size(95, 65);
            this.bttnInfoPersonal.TabIndex = 2;
            this.bttnInfoPersonal.Text = "Información personal";
            this.mA.SetToolTip(this.bttnInfoPersonal, "Aquí podrás ver tu información personal y actualizar tus datos.");
            this.bttnInfoPersonal.UseVisualStyleBackColor = false;
            this.bttnInfoPersonal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnklblcerrarSesion
            // 
            this.lnklblcerrarSesion.AutoSize = true;
            this.lnklblcerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lnklblcerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblcerrarSesion.LinkColor = System.Drawing.Color.Red;
            this.lnklblcerrarSesion.Location = new System.Drawing.Point(268, 321);
            this.lnklblcerrarSesion.Name = "lnklblcerrarSesion";
            this.lnklblcerrarSesion.Size = new System.Drawing.Size(70, 13);
            this.lnklblcerrarSesion.TabIndex = 3;
            this.lnklblcerrarSesion.TabStop = true;
            this.lnklblcerrarSesion.Text = "Cerrar Sesión";
            this.lnklblcerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblcerrarSesion_LinkClicked);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_07_26_at_11_26_48_AM;
            this.ClientSize = new System.Drawing.Size(583, 374);
            this.Controls.Add(this.lnklblcerrarSesion);
            this.Controls.Add(this.gbxinformacionPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.gbxinformacionPersonal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Button btnoferta;
        private System.Windows.Forms.GroupBox gbxinformacionPersonal;
        private System.Windows.Forms.LinkLabel lnklblcerrarSesion;
        private System.Windows.Forms.Button bttnInfoPersonal;
        private System.Windows.Forms.ToolTip mA;
    }
}