namespace MiPrimeraAplicacion
{
    partial class MiPrimeraAplicación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiPrimeraAplicación));
            this.boton1BTN = new System.Windows.Forms.Button();
            this.Texto1LB = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton1BTN
            // 
            this.boton1BTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.boton1BTN.Enabled = false;
            this.boton1BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton1BTN.Image = ((System.Drawing.Image)(resources.GetObject("boton1BTN.Image")));
            this.boton1BTN.Location = new System.Drawing.Point(57, 12);
            this.boton1BTN.Name = "boton1BTN";
            this.boton1BTN.Size = new System.Drawing.Size(75, 23);
            this.boton1BTN.TabIndex = 0;
            this.boton1BTN.Text = "Presionar";
            this.boton1BTN.UseVisualStyleBackColor = false;
            this.boton1BTN.Click += new System.EventHandler(this.boton1BTN_Click);
            // 
            // Texto1LB
            // 
            this.Texto1LB.AutoSize = true;
            this.Texto1LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Texto1LB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1LB.ForeColor = System.Drawing.Color.IndianRed;
            this.Texto1LB.Location = new System.Drawing.Point(222, 13);
            this.Texto1LB.Name = "Texto1LB";
            this.Texto1LB.Size = new System.Drawing.Size(70, 18);
            this.Texto1LB.TabIndex = 1;
            this.Texto1LB.Text = "BlueLabel";
            this.Texto1LB.MouseLeave += new System.EventHandler(this.Texto1LB_MouseLeave);
            this.Texto1LB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Texto1LB_MouseMove);
            // 
            // TextInput
            // 
            this.TextInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextInput.Location = new System.Drawing.Point(405, 10);
            this.TextInput.MaxLength = 100;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(100, 20);
            this.TextInput.TabIndex = 2;
            this.TextInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextInput_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(437, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // MiPrimeraAplicación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.Texto1LB);
            this.Controls.Add(this.boton1BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiPrimeraAplicación";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimeraAplicación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiPrimeraAplicación_FormClosing);
            this.Load += new System.EventHandler(this.MiPrimeraAplicación_Load);
            this.Click += new System.EventHandler(this.MiPrimeraAplicación_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1BTN;
        private System.Windows.Forms.Label Texto1LB;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.TextBox textBox2;
    }
}

