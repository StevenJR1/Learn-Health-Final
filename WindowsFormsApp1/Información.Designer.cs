namespace WindowsFormsApp1
{
    partial class Información
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Información));
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxinformacionPersonal = new System.Windows.Forms.GroupBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxSalario = new System.Windows.Forms.TextBox();
            this.txtBxSexo = new System.Windows.Forms.TextBox();
            this.txtfechaNac = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.gbxinformacionContacto = new System.Windows.Forms.GroupBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.gbxidentificacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.txtBxTipodoc = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.Btncrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnMInformacion = new System.Windows.Forms.Button();
            this.mA2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.gbxinformacionPersonal.SuspendLayout();
            this.gbxinformacionContacto.SuspendLayout();
            this.gbxidentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.Location = new System.Drawing.Point(649, 379);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(92, 46);
            this.bttnEliminar.TabIndex = 19;
            this.bttnEliminar.Text = "Eliminar información";
            this.mA2.SetToolTip(this.bttnEliminar, "Digite su número de documento.");
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnModificar
            // 
            this.bttnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnModificar.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificar.Location = new System.Drawing.Point(543, 379);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(100, 46);
            this.bttnModificar.TabIndex = 18;
            this.bttnModificar.Text = "Modificar información";
            this.mA2.SetToolTip(this.bttnModificar, "Digite su código (Si no conoce cual es su código, \r\nlo puede ver dándole clic al " +
        "botón “mostrar información”).");
            this.bttnModificar.UseVisualStyleBackColor = false;
            this.bttnModificar.Click += new System.EventHandler(this.bttnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(444, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 145);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usuario ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtUsuario.Location = new System.Drawing.Point(141, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 21);
            this.txtUsuario.TabIndex = 47;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtContraseña.Location = new System.Drawing.Point(141, 99);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(148, 21);
            this.txtContraseña.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Contraseña";
            // 
            // gbxinformacionPersonal
            // 
            this.gbxinformacionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxinformacionPersonal.Controls.Add(this.txtSApellido);
            this.gbxinformacionPersonal.Controls.Add(this.label4);
            this.gbxinformacionPersonal.Controls.Add(this.txtSNombre);
            this.gbxinformacionPersonal.Controls.Add(this.label5);
            this.gbxinformacionPersonal.Controls.Add(this.txtBxSalario);
            this.gbxinformacionPersonal.Controls.Add(this.txtBxSexo);
            this.gbxinformacionPersonal.Controls.Add(this.txtfechaNac);
            this.gbxinformacionPersonal.Controls.Add(this.lbl5);
            this.gbxinformacionPersonal.Controls.Add(this.lbl6);
            this.gbxinformacionPersonal.Controls.Add(this.lbl11);
            this.gbxinformacionPersonal.Controls.Add(this.txtPApellido);
            this.gbxinformacionPersonal.Controls.Add(this.txtPNombre);
            this.gbxinformacionPersonal.Controls.Add(this.lbl3);
            this.gbxinformacionPersonal.Controls.Add(this.lbl4);
            this.gbxinformacionPersonal.Location = new System.Drawing.Point(13, 196);
            this.gbxinformacionPersonal.Name = "gbxinformacionPersonal";
            this.gbxinformacionPersonal.Size = new System.Drawing.Size(339, 287);
            this.gbxinformacionPersonal.TabIndex = 58;
            this.gbxinformacionPersonal.TabStop = false;
            this.gbxinformacionPersonal.Text = "Información personal";
            // 
            // txtSApellido
            // 
            this.txtSApellido.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSApellido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSApellido.Location = new System.Drawing.Point(164, 121);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(120, 21);
            this.txtSApellido.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(164, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Segundo apellido";
            // 
            // txtSNombre
            // 
            this.txtSNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSNombre.Location = new System.Drawing.Point(167, 57);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(120, 21);
            this.txtSNombre.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(164, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Segundo nombre";
            // 
            // txtBxSalario
            // 
            this.txtBxSalario.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSalario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBxSalario.Location = new System.Drawing.Point(167, 235);
            this.txtBxSalario.Name = "txtBxSalario";
            this.txtBxSalario.Size = new System.Drawing.Size(148, 21);
            this.txtBxSalario.TabIndex = 45;
            // 
            // txtBxSexo
            // 
            this.txtBxSexo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSexo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBxSexo.Location = new System.Drawing.Point(167, 194);
            this.txtBxSexo.Name = "txtBxSexo";
            this.txtBxSexo.Size = new System.Drawing.Size(79, 21);
            this.txtBxSexo.TabIndex = 44;
            // 
            // txtfechaNac
            // 
            this.txtfechaNac.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaNac.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtfechaNac.Location = new System.Drawing.Point(167, 157);
            this.txtfechaNac.Name = "txtfechaNac";
            this.txtfechaNac.Size = new System.Drawing.Size(148, 21);
            this.txtfechaNac.TabIndex = 43;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl5.Location = new System.Drawing.Point(21, 157);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(133, 17);
            this.lbl5.TabIndex = 31;
            this.lbl5.Text = "Fecha de nacimiento ";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl6.Location = new System.Drawing.Point(21, 200);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(37, 17);
            this.lbl6.TabIndex = 32;
            this.lbl6.Text = "Sexo";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl11.Location = new System.Drawing.Point(18, 237);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(126, 17);
            this.lbl11.TabIndex = 37;
            this.lbl11.Text = "Salario que devenga";
            // 
            // txtPApellido
            // 
            this.txtPApellido.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPApellido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPApellido.Location = new System.Drawing.Point(24, 117);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(105, 21);
            this.txtPApellido.TabIndex = 41;
            // 
            // txtPNombre
            // 
            this.txtPNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPNombre.Location = new System.Drawing.Point(24, 56);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(105, 21);
            this.txtPNombre.TabIndex = 42;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl3.Location = new System.Drawing.Point(21, 30);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(56, 17);
            this.lbl3.TabIndex = 29;
            this.lbl3.Text = "Nombre";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl4.Location = new System.Drawing.Point(21, 87);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(62, 17);
            this.lbl4.TabIndex = 30;
            this.lbl4.Text = "Apellidos";
            // 
            // gbxinformacionContacto
            // 
            this.gbxinformacionContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxinformacionContacto.Controls.Add(this.lbl10);
            this.gbxinformacionContacto.Controls.Add(this.txtNumTelefono);
            this.gbxinformacionContacto.Controls.Add(this.txtDireccion);
            this.gbxinformacionContacto.Controls.Add(this.lbl9);
            this.gbxinformacionContacto.Location = new System.Drawing.Point(444, 12);
            this.gbxinformacionContacto.Name = "gbxinformacionContacto";
            this.gbxinformacionContacto.Size = new System.Drawing.Size(297, 145);
            this.gbxinformacionContacto.TabIndex = 57;
            this.gbxinformacionContacto.TabStop = false;
            this.gbxinformacionContacto.Text = "Información de contacto";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl10.Location = new System.Drawing.Point(18, 42);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(94, 17);
            this.lbl10.TabIndex = 36;
            this.lbl10.Text = "N° de teléfono";
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTelefono.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNumTelefono.Location = new System.Drawing.Point(141, 40);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(148, 21);
            this.txtNumTelefono.TabIndex = 47;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDireccion.Location = new System.Drawing.Point(141, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(148, 21);
            this.txtDireccion.TabIndex = 46;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl9.Location = new System.Drawing.Point(18, 99);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(65, 17);
            this.lbl9.TabIndex = 35;
            this.lbl9.Text = "Dirección";
            // 
            // gbxidentificacion
            // 
            this.gbxidentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxidentificacion.Controls.Add(this.label3);
            this.gbxidentificacion.Controls.Add(this.txtBxCodigo);
            this.gbxidentificacion.Controls.Add(this.txtBxTipodoc);
            this.gbxidentificacion.Controls.Add(this.lbl7);
            this.gbxidentificacion.Controls.Add(this.lbl8);
            this.gbxidentificacion.Controls.Add(this.txtNDoc);
            this.gbxidentificacion.Location = new System.Drawing.Point(12, 12);
            this.gbxidentificacion.Name = "gbxidentificacion";
            this.gbxidentificacion.Size = new System.Drawing.Size(340, 158);
            this.gbxidentificacion.TabIndex = 56;
            this.gbxidentificacion.TabStop = false;
            this.gbxidentificacion.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Código";
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBxCodigo.Location = new System.Drawing.Point(175, 112);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(84, 21);
            this.txtBxCodigo.TabIndex = 42;
            // 
            // txtBxTipodoc
            // 
            this.txtBxTipodoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTipodoc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBxTipodoc.Location = new System.Drawing.Point(175, 74);
            this.txtBxTipodoc.Name = "txtBxTipodoc";
            this.txtBxTipodoc.Size = new System.Drawing.Size(148, 21);
            this.txtBxTipodoc.TabIndex = 40;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl7.Location = new System.Drawing.Point(6, 76);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(123, 17);
            this.lbl7.TabIndex = 33;
            this.lbl7.Text = "Tipo de documento ";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl8.Location = new System.Drawing.Point(6, 30);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(124, 17);
            this.lbl8.TabIndex = 34;
            this.lbl8.Text = "N° de identificación";
            // 
            // txtNDoc
            // 
            this.txtNDoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDoc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNDoc.Location = new System.Drawing.Point(175, 28);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(148, 21);
            this.txtNDoc.TabIndex = 39;
            // 
            // Btncrear
            // 
            this.Btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btncrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btncrear.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btncrear.Location = new System.Drawing.Point(465, 446);
            this.Btncrear.Name = "Btncrear";
            this.Btncrear.Size = new System.Drawing.Size(114, 37);
            this.Btncrear.TabIndex = 55;
            this.Btncrear.Text = "Volver";
            this.Btncrear.UseVisualStyleBackColor = false;
            this.Btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(609, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 60;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnMInformacion
            // 
            this.bttnMInformacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnMInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttnMInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnMInformacion.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMInformacion.Location = new System.Drawing.Point(447, 379);
            this.bttnMInformacion.Name = "bttnMInformacion";
            this.bttnMInformacion.Size = new System.Drawing.Size(90, 46);
            this.bttnMInformacion.TabIndex = 61;
            this.bttnMInformacion.Text = "Mostrar información";
            this.mA2.SetToolTip(this.bttnMInformacion, "Digite su número de documento.\r\n");
            this.bttnMInformacion.UseVisualStyleBackColor = false;
            this.bttnMInformacion.Click += new System.EventHandler(this.bttnMInformacion_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Información
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Registro_2;
            this.ClientSize = new System.Drawing.Size(773, 498);
            this.Controls.Add(this.bttnMInformacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxinformacionPersonal);
            this.Controls.Add(this.gbxinformacionContacto);
            this.Controls.Add(this.gbxidentificacion);
            this.Controls.Add(this.Btncrear);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Información";
            this.Text = "Información personal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxinformacionPersonal.ResumeLayout(false);
            this.gbxinformacionPersonal.PerformLayout();
            this.gbxinformacionContacto.ResumeLayout(false);
            this.gbxinformacionContacto.PerformLayout();
            this.gbxidentificacion.ResumeLayout(false);
            this.gbxidentificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxinformacionPersonal;
        private System.Windows.Forms.TextBox txtBxSalario;
        private System.Windows.Forms.TextBox txtBxSexo;
        private System.Windows.Forms.TextBox txtfechaNac;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.GroupBox gbxinformacionContacto;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.GroupBox gbxidentificacion;
        private System.Windows.Forms.TextBox txtBxTipodoc;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.Button Btncrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Button bttnMInformacion;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip mA2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}