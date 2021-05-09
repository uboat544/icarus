namespace CalcularNomina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.txtasignaciondia = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.btnalmacenarregistro = new System.Windows.Forms.Button();
            this.btncalcularsalario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsueldototal = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario por dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dias Trabajados";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(227, 65);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(190, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(227, 106);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(189, 20);
            this.txtidentificacion.TabIndex = 5;
            // 
            // txtasignaciondia
            // 
            this.txtasignaciondia.Location = new System.Drawing.Point(230, 142);
            this.txtasignaciondia.Name = "txtasignaciondia";
            this.txtasignaciondia.Size = new System.Drawing.Size(186, 20);
            this.txtasignaciondia.TabIndex = 6;
            this.txtasignaciondia.TextChanged += new System.EventHandler(this.txtasignaciondia_TextChanged);
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(226, 178);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(190, 20);
            this.txtsueldo.TabIndex = 7;
            // 
            // btnalmacenarregistro
            // 
            this.btnalmacenarregistro.Location = new System.Drawing.Point(107, 232);
            this.btnalmacenarregistro.Name = "btnalmacenarregistro";
            this.btnalmacenarregistro.Size = new System.Drawing.Size(260, 48);
            this.btnalmacenarregistro.TabIndex = 8;
            this.btnalmacenarregistro.Text = "Guardar Registro de Empleado";
            this.btnalmacenarregistro.UseVisualStyleBackColor = true;
            this.btnalmacenarregistro.Click += new System.EventHandler(this.btnalmacenarregistro_Click);
            // 
            // btncalcularsalario
            // 
            this.btncalcularsalario.Location = new System.Drawing.Point(114, 301);
            this.btncalcularsalario.Name = "btncalcularsalario";
            this.btncalcularsalario.Size = new System.Drawing.Size(252, 46);
            this.btncalcularsalario.TabIndex = 9;
            this.btncalcularsalario.Text = "Calcular Salario";
            this.btncalcularsalario.UseVisualStyleBackColor = true;
            this.btncalcularsalario.Click += new System.EventHandler(this.btncalcularsalario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sueldo Total";
            // 
            // txtsueldototal
            // 
            this.txtsueldototal.Location = new System.Drawing.Point(226, 380);
            this.txtsueldototal.Name = "txtsueldototal";
            this.txtsueldototal.Size = new System.Drawing.Size(100, 20);
            this.txtsueldototal.TabIndex = 11;
            this.txtsueldototal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(102, 431);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 12;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(242, 431);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 491);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtsueldototal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalcularsalario);
            this.Controls.Add(this.btnalmacenarregistro);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtasignaciondia);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.TextBox txtasignaciondia;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Button btnalmacenarregistro;
        private System.Windows.Forms.Button btncalcularsalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsueldototal;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
    }
}

