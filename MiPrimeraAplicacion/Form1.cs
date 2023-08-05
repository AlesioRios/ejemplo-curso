using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class MiPrimeraAplicación : Form
    {
        public MiPrimeraAplicación()
        {
            InitializeComponent();
        }

        private void MiPrimeraAplicación_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido a miPrimeraApp.com!");
        }

        private void MiPrimeraAplicación_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Muchas gracias por usar la App. ¡Regresá pronto!");
        }

        private void boton1BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted presionó el botón. Precaución.");
            this.BackColor = Color.Blue;
            if (TextInput.Text == "")
                TextInput.BackColor = Color.Red;
            else
                TextInput.BackColor = System.Drawing.SystemColors.Control;
        }

        
        private void MiPrimeraAplicación_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón izquierdo.");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón derecho.");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el botón del medio.");

        }

        private void Texto1LB_MouseMove(object sender, MouseEventArgs e)
        {
            Texto1LB.BackColor = Color.Brown;
            Texto1LB.Cursor = Cursors.Hand;
        }

        private void Texto1LB_MouseLeave(object sender, EventArgs e)
        {
            Texto1LB.BackColor = System.Drawing.SystemColors.Control;
            Texto1LB.Cursor = Cursors.Arrow;


        }

        private void TextInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 59 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene" + textBox2.Text.Length + "caracteres.");
        }
    }
}