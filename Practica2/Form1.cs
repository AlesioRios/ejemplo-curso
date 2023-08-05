using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EdadLB_Click(object sender, EventArgs e)
        {

        }
        List<TextBox> datos = new List<TextBox>();
        private void AceptarBTN_Click(object sender, EventArgs e)
        {
            bool incompleto = false;
            foreach (var data in datos)
            {
                if (data.Text == "" || data.Text == "Completar")
                {
                    data.BackColor = Color.Red;
                    incompleto = true;
                }
            }
            if (incompleto == true)
                MessageBox.Show("Por favor ingrese todos los datos.");
            else
            {
              
                ResultadosRTB.Text = $"Nombre completo: {Nombre.Text} {Apellido.Text}.\nEdad: {Edad.Text}.\nDirección: {Dirección.Text}.";
            }
        }

        private void AceptarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            AceptarBTN.BackColor = Color.Green;
            AceptarBTN.ForeColor = Color.White;
            AceptarBTN.Cursor = Cursors.Hand;
            
        }

        private void AceptarBTN_MouseLeave(object sender, EventArgs e)
        {
            AceptarBTN.BackColor = System.Drawing.SystemColors.Control;
            AceptarBTN.ForeColor = Color.Black;
            AceptarBTN.Cursor = Cursors.Arrow;

        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por usar el programa.");
            this.Close();
        }

        private void CancelarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            CancelarBTN.BackColor = Color.Red;
            CancelarBTN.ForeColor = Color.White;
            CancelarBTN.Cursor = Cursors.Hand;
        }

        private void CancelarBTN_MouseLeave(object sender, EventArgs e)
        {
            CancelarBTN.BackColor = System.Drawing.SystemColors.Control;
            CancelarBTN.ForeColor = Color.Black;
            CancelarBTN.Cursor = Cursors.Arrow;
        }

        private void Nombre_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "Completar" || Nombre.BackColor == Color.Red)
            {
                Nombre.Text = "";
                Nombre.ForeColor = Color.Black;
                Nombre.BackColor = System.Drawing.SystemColors.Control;

            }
        }

        private void Nombre_Leave(object sender, EventArgs e)
        {
            Nombre.BackColor = Color.White;
            if (Nombre.Text == "")
            {
                Nombre.ForeColor = Color.LightGray;
                Nombre.Text = "Completar";
            }
            else
                Nombre.Text = Nombre.Text.ToUpper();
           
        }

        private void Apellido_Click(object sender, EventArgs e)
        {
            if (Apellido.Text == "Completar" || Apellido.BackColor == Color.Red)
            {
                Apellido.Text = "";
                Apellido.ForeColor = Color.Black;
                Apellido.BackColor = System.Drawing.SystemColors.Control;

            }
        }

        private void Apellido_Leave(object sender, EventArgs e)
        {
            Apellido.BackColor = Color.White;

            if (Apellido.Text == "")
            {
                Apellido.Text = "Completar";
                Apellido.ForeColor = Color.LightGray;
            }
            else
                Apellido.Text = Apellido.Text.ToUpper();

        }

        private void Edad_Click(object sender, EventArgs e)
        {
            if (Edad.Text == "Completar" || Edad.BackColor == Color.Red)
            {
                Edad.Text = "";
                Edad.ForeColor = Color.Black;
                Edad.BackColor = System.Drawing.SystemColors.Control;

            }
        }

        private void Edad_Leave(object sender, EventArgs e)
        {
            Edad.BackColor = Color.White;
            if (Edad.Text == "")
            {
                Edad.Text = "Completar";
                Edad.ForeColor = Color.LightGray;
            }

        }

        private void Dirección_Click(object sender, EventArgs e)
        {
            if (Dirección.Text == "Completar" || Dirección.BackColor == Color.Red)
            {
                Dirección.Text = "";
                Dirección.ForeColor = Color.Black;
                Dirección.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void Dirección_Leave(object sender, EventArgs e)
        {
            Dirección.BackColor = Color.White;
            if (Dirección.Text == "")
            {
                Dirección.Text = "Completar";
                Dirección.ForeColor = Color.LightGray;
            }
            else
                Dirección.Text = Dirección.Text.ToUpper();

        }

        private void Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datos.Add(Nombre);
            datos.Add(Apellido);
            datos.Add(Edad);
            datos.Add(Dirección);
        }
    }
}
