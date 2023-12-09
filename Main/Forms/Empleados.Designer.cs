namespace Main.Forms
{
    partial class Empleados
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.pnlContainerEmpleados = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgRoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlContainerEmpleados.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRoles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPersonal, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRoles
            // 
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Location = new System.Drawing.Point(365, 1);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(364, 31);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "ROLES";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.Location = new System.Drawing.Point(1, 1);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(363, 31);
            this.btnPersonal.TabIndex = 0;
            this.btnPersonal.Text = "PERSONAL";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // pnlContainerEmpleados
            // 
            this.pnlContainerEmpleados.Controls.Add(this.txtContraseña);
            this.pnlContainerEmpleados.Controls.Add(this.label7);
            this.pnlContainerEmpleados.Controls.Add(this.dtpNacimiento);
            this.pnlContainerEmpleados.Controls.Add(this.label6);
            this.pnlContainerEmpleados.Controls.Add(this.label3);
            this.pnlContainerEmpleados.Controls.Add(this.txtTelefono);
            this.pnlContainerEmpleados.Controls.Add(this.tableLayoutPanel2);
            this.pnlContainerEmpleados.Controls.Add(this.label5);
            this.pnlContainerEmpleados.Controls.Add(this.txtCorreo);
            this.pnlContainerEmpleados.Controls.Add(this.label4);
            this.pnlContainerEmpleados.Controls.Add(this.txtCedula);
            this.pnlContainerEmpleados.Controls.Add(this.button1);
            this.pnlContainerEmpleados.Controls.Add(this.pictureBox1);
            this.pnlContainerEmpleados.Controls.Add(this.cmbRol);
            this.pnlContainerEmpleados.Controls.Add(this.label2);
            this.pnlContainerEmpleados.Controls.Add(this.dtgRoles);
            this.pnlContainerEmpleados.Controls.Add(this.label1);
            this.pnlContainerEmpleados.Controls.Add(this.txtNombre);
            this.pnlContainerEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerEmpleados.Location = new System.Drawing.Point(0, 33);
            this.pnlContainerEmpleados.Name = "pnlContainerEmpleados";
            this.pnlContainerEmpleados.Size = new System.Drawing.Size(730, 525);
            this.pnlContainerEmpleados.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 462);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 50);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(138, 50);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Main.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 44);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::Main.Properties.Resources.actualizar;
            this.btnModificar.Location = new System.Drawing.Point(72, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(63, 44);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnLimpiar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEliminar, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(138, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(138, 50);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Main.Properties.Resources.limpieza;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(63, 44);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Main.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(72, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 44);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Correo electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(12, 233);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(276, 27);
            this.txtCorreo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id del empleado *";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(12, 115);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(276, 27);
            this.txtCedula.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Main.Properties.Resources.imagen;
            this.button1.Location = new System.Drawing.Point(88, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Elegir imagen";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(146)))));
            this.pictureBox1.BackgroundImage = global::Main.Properties.Resources.sin_imagen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(144, 362);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(144, 31);
            this.cmbRol.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label2.Location = new System.Drawing.Point(7, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rol designado *";
            // 
            // dtgRoles
            // 
            this.dtgRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoles.Location = new System.Drawing.Point(305, 13);
            this.dtgRoles.Name = "dtgRoles";
            this.dtgRoles.Size = new System.Drawing.Size(413, 499);
            this.dtgRoles.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label1.Location = new System.Drawing.Point(7, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del empleado *";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(12, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 27);
            this.txtNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label3.Location = new System.Drawing.Point(7, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefono o celular";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(12, 292);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(276, 27);
            this.txtTelefono.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label6.Location = new System.Drawing.Point(7, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "F. Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(144, 325);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(144, 27);
            this.dtpNacimiento.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label7.Location = new System.Drawing.Point(7, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña *";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(12, 425);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(276, 27);
            this.txtContraseña.TabIndex = 31;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 558);
            this.Controls.Add(this.pnlContainerEmpleados);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlContainerEmpleados.ResumeLayout(false);
            this.pnlContainerEmpleados.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlContainerEmpleados;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label7;
    }
}