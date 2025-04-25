using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRepasoLaboratorio1y2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido", "Sistema de viernes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosicion.Text = e.Location.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            if (chkComida1.Checked==true)
            {
                lblResultado.Text += " "+ chkComida1.Text;
            }

            if (chkComida2.Checked == true)
            {
                lblResultado.Text += " " + chkComida2.Text;
            }

            if (chkComida3.Checked == true)
            {
                lblResultado.Text += " " + chkComida3.Text;
            }

            //verificar el contenido de cada control
            if (txtNombre.Text!="")
            {
                if (cboPagos.SelectedIndex != -1)
                {
                    MessageBox.Show("almacenando sus datos...");
                }
                else
                {
                    cboPagos.BackColor = Color.Red;
                    cboPagos.Focus();

                }
            }
            else
            {
                txtNombre.Text = "cargue datos aquí!";
                txtNombre.Focus(); 
                txtNombre.BackColor = Color.Red;
            }

            //MessageBox.Show("Acepta ♥", "Sistema de viernes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancela ☺", "Sistema de viernes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtNombre.BackColor = Color.LightGreen;

               // btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                txtNombre.BackColor = Color.Yellow;

               // btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void cboPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPagos.BackColor = Color.Green;
        }
    }
}
