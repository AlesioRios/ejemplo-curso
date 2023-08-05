namespace Practica2
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
            this.NombreLB1 = new System.Windows.Forms.Label();
            this.ApellidoLB2 = new System.Windows.Forms.Label();
            this.EdadLB3 = new System.Windows.Forms.Label();
            this.DireccionLB4 = new System.Windows.Forms.Label();
            this.ResultadoLB = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Dirección = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.AceptarBTN = new System.Windows.Forms.Button();
            this.CancelarBTN = new System.Windows.Forms.Button();
            this.ResultadosRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NombreLB1
            // 
            this.NombreLB1.AutoSize = true;
            this.NombreLB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLB1.Location = new System.Drawing.Point(55, 28);
            this.NombreLB1.Name = "NombreLB1";
            this.NombreLB1.Size = new System.Drawing.Size(66, 16);
            this.NombreLB1.TabIndex = 0;
            this.NombreLB1.Text = "NOMBRE";
            // 
            // ApellidoLB2
            // 
            this.ApellidoLB2.AutoSize = true;
            this.ApellidoLB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoLB2.Location = new System.Drawing.Point(55, 65);
            this.ApellidoLB2.Name = "ApellidoLB2";
            this.ApellidoLB2.Size = new System.Drawing.Size(71, 16);
            this.ApellidoLB2.TabIndex = 1;
            this.ApellidoLB2.Text = "APELLIDO";
            // 
            // EdadLB3
            // 
            this.EdadLB3.AutoSize = true;
            this.EdadLB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadLB3.Location = new System.Drawing.Point(55, 100);
            this.EdadLB3.Name = "EdadLB3";
            this.EdadLB3.Size = new System.Drawing.Size(45, 16);
            this.EdadLB3.TabIndex = 2;
            this.EdadLB3.Text = "EDAD";
            this.EdadLB3.Click += new System.EventHandler(this.EdadLB_Click);
            // 
            // DireccionLB4
            // 
            this.DireccionLB4.AutoSize = true;
            this.DireccionLB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLB4.Location = new System.Drawing.Point(55, 133);
            this.DireccionLB4.Name = "DireccionLB4";
            this.DireccionLB4.Size = new System.Drawing.Size(80, 16);
            this.DireccionLB4.TabIndex = 3;
            this.DireccionLB4.Text = "DIRECCIÓN";
            // 
            // ResultadoLB
            // 
            this.ResultadoLB.AutoSize = true;
            this.ResultadoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLB.Location = new System.Drawing.Point(55, 178);
            this.ResultadoLB.Name = "ResultadoLB";
            this.ResultadoLB.Size = new System.Drawing.Size(90, 16);
            this.ResultadoLB.TabIndex = 4;
            this.ResultadoLB.Text = "RESULTADO";
            // 
            // Nombre
            // 
            this.Nombre.ForeColor = System.Drawing.Color.LightGray;
            this.Nombre.Location = new System.Drawing.Point(149, 24);
            this.Nombre.MaxLength = 100;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(394, 20);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Completar";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            this.Nombre.Leave += new System.EventHandler(this.Nombre_Leave);
            // 
            // Apellido
            // 
            this.Apellido.ForeColor = System.Drawing.Color.LightGray;
            this.Apellido.Location = new System.Drawing.Point(149, 61);
            this.Apellido.MaxLength = 100;
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(394, 20);
            this.Apellido.TabIndex = 6;
            this.Apellido.Text = "Completar";
            this.Apellido.Click += new System.EventHandler(this.Apellido_Click);
            this.Apellido.Leave += new System.EventHandler(this.Apellido_Leave);
            // 
            // Edad
            // 
            this.Edad.ForeColor = System.Drawing.Color.LightGray;
            this.Edad.Location = new System.Drawing.Point(149, 96);
            this.Edad.MaxLength = 100;
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(394, 20);
            this.Edad.TabIndex = 7;
            this.Edad.Text = "Completar";
            this.Edad.Click += new System.EventHandler(this.Edad_Click);
            this.Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edad_KeyPress);
            this.Edad.Leave += new System.EventHandler(this.Edad_Leave);
            // 
            // Dirección
            // 
            this.Dirección.ForeColor = System.Drawing.Color.LightGray;
            this.Dirección.Location = new System.Drawing.Point(149, 129);
            this.Dirección.MaxLength = 100;
            this.Dirección.Name = "Dirección";
            this.Dirección.Size = new System.Drawing.Size(394, 20);
            this.Dirección.TabIndex = 8;
            this.Dirección.Text = "Completar";
            this.Dirección.Click += new System.EventHandler(this.Dirección_Click);
            this.Dirección.Leave += new System.EventHandler(this.Dirección_Leave);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(58, 207);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(485, 146);
            this.Resultado.TabIndex = 9;
            // 
            // AceptarBTN
            // 
            this.AceptarBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AceptarBTN.Location = new System.Drawing.Point(130, 371);
            this.AceptarBTN.Name = "AceptarBTN";
            this.AceptarBTN.Size = new System.Drawing.Size(110, 35);
            this.AceptarBTN.TabIndex = 10;
            this.AceptarBTN.Text = "Aceptar";
            this.AceptarBTN.UseVisualStyleBackColor = true;
            this.AceptarBTN.Click += new System.EventHandler(this.AceptarBTN_Click);
            this.AceptarBTN.MouseLeave += new System.EventHandler(this.AceptarBTN_MouseLeave);
            this.AceptarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AceptarBTN_MouseMove);
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.Location = new System.Drawing.Point(361, 371);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(110, 35);
            this.CancelarBTN.TabIndex = 11;
            this.CancelarBTN.Text = "Cancelar";
            this.CancelarBTN.UseVisualStyleBackColor = true;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            this.CancelarBTN.MouseLeave += new System.EventHandler(this.CancelarBTN_MouseLeave);
            this.CancelarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelarBTN_MouseMove);
            // 
            // ResultadosRTB
            // 
            this.ResultadosRTB.Location = new System.Drawing.Point(58, 207);
            this.ResultadosRTB.Name = "ResultadosRTB";
            this.ResultadosRTB.Size = new System.Drawing.Size(485, 146);
            this.ResultadosRTB.TabIndex = 12;
            this.ResultadosRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.ResultadosRTB);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.AceptarBTN);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Dirección);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ResultadoLB);
            this.Controls.Add(this.DireccionLB4);
            this.Controls.Add(this.EdadLB3);
            this.Controls.Add(this.ApellidoLB2);
            this.Controls.Add(this.NombreLB1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLB1;
        private System.Windows.Forms.Label ApellidoLB2;
        private System.Windows.Forms.Label EdadLB3;
        private System.Windows.Forms.Label DireccionLB4;
        private System.Windows.Forms.Label ResultadoLB;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox Dirección;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button AceptarBTN;
        private System.Windows.Forms.Button CancelarBTN;
        private System.Windows.Forms.RichTextBox ResultadosRTB;
    }
}

