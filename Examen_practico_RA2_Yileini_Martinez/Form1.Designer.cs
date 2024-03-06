namespace Examen_practico_RA2_Yileini_Martinez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Maestro_titular = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.rb_Femenino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maestro_titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_tecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso_sesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            this.cb_area_tecnica = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dlg_Guardar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maestro_titular";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(145, 132);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(664, 89);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_Maestro_titular
            // 
            this.txt_Maestro_titular.Location = new System.Drawing.Point(664, 137);
            this.txt_Maestro_titular.Name = "txt_Maestro_titular";
            this.txt_Maestro_titular.Size = new System.Drawing.Size(100, 20);
            this.txt_Maestro_titular.TabIndex = 8;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(411, 133);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 9;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(411, 89);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 10;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(145, 86);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_Matricula.TabIndex = 11;
            // 
            // rb_Femenino
            // 
            this.rb_Femenino.AutoSize = true;
            this.rb_Femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Femenino.Location = new System.Drawing.Point(49, 247);
            this.rb_Femenino.Name = "rb_Femenino";
            this.rb_Femenino.Size = new System.Drawing.Size(93, 20);
            this.rb_Femenino.TabIndex = 14;
            this.rb_Femenino.TabStop = true;
            this.rb_Femenino.Text = "Femenino";
            this.rb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Masculino.Location = new System.Drawing.Point(49, 292);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(95, 20);
            this.rb_Masculino.TabIndex = 15;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.Text = "Masculino";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(883, 69);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(85, 33);
            this.btn_Nuevo.TabIndex = 16;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(883, 113);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(85, 33);
            this.btn_Agregar.TabIndex = 19;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(883, 159);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(85, 33);
            this.btn_Eliminar.TabIndex = 20;
            this.btn_Eliminar.Text = "Elimnar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(883, 204);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(85, 33);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Curso y Sesion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Area_Tecnica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Genero";
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nombre,
            this.direccion,
            this.telefono,
            this.email,
            this.maestro_titular,
            this.genero,
            this.area_tecnica,
            this.curso_sesion});
            this.dgv_Datos.Location = new System.Drawing.Point(12, 409);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.Size = new System.Drawing.Size(937, 150);
            this.dgv_Datos.TabIndex = 25;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // maestro_titular
            // 
            this.maestro_titular.HeaderText = "Maestro_titular";
            this.maestro_titular.Name = "maestro_titular";
            // 
            // genero
            // 
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            // 
            // area_tecnica
            // 
            this.area_tecnica.HeaderText = "Area_Tecnica";
            this.area_tecnica.Name = "area_tecnica";
            // 
            // curso_sesion
            // 
            this.curso_sesion.HeaderText = "Curso_Sesion";
            this.curso_sesion.Name = "curso_sesion";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(883, 249);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(85, 33);
            this.btn_Guardar.TabIndex = 26;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cb_curso
            // 
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Items.AddRange(new object[] {
            "5D1",
            "5D2",
            "4C1",
            "4C2",
            "5A1",
            "5A2"});
            this.cb_curso.Location = new System.Drawing.Point(235, 256);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(121, 21);
            this.cb_curso.TabIndex = 27;
            // 
            // cb_area_tecnica
            // 
            this.cb_area_tecnica.FormattingEnabled = true;
            this.cb_area_tecnica.Items.AddRange(new object[] {
            "Informatica",
            "Gastronomia",
            "Emfermeria"});
            this.cb_area_tecnica.Location = new System.Drawing.Point(465, 256);
            this.cb_area_tecnica.Name = "cb_area_tecnica";
            this.cb_area_tecnica.Size = new System.Drawing.Size(121, 21);
            this.cb_area_tecnica.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(308, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Dato del alumno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 586);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_area_tecnica);
            this.Controls.Add(this.cb_curso);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgv_Datos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.rb_Masculino);
            this.Controls.Add(this.rb_Femenino);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Maestro_titular);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Maestro_titular;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.RadioButton rb_Femenino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn maestro_titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_tecnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso_sesion;
        private System.Windows.Forms.ComboBox cb_curso;
        private System.Windows.Forms.ComboBox cb_area_tecnica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog dlg_Guardar;
    }
}

