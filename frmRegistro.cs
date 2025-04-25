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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cboTipoProducto.Items.Add("CPU");
            cboTipoProducto.Items.Add("RAM");
            cboTipoProducto.Items.Add("SSD");
        }

        private void cuandoEscribaTexto(object sender, EventArgs e)
        {
            if (txtCodigo.Text!="")
            {
                int cantidadletras = txtCodigo.Text.Count();
                if (cantidadletras>4)
                {
                    txtCodigo.Enabled= false;
                }

                cboTipoProducto.Enabled = true;
            }
            else
            {
                cboTipoProducto.Enabled = false;
            }
        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoProducto.SelectedIndex!=-1)
            {
                txtCantidad.Enabled = true;
            }
            else
            {
                txtCantidad.Enabled = false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text!="")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled=false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add(txtCodigo.Text, cboTipoProducto.Text, txtCantidad.Text);


            DataGridView grilla = new DataGridView();
            Controls.Add(grilla);
            grilla.Location = new System.Drawing.Point(30, 400);

            grilla.Columns.Add("Codigo", "Codigo");
            grilla.Columns.Add("Tipo", "Tipo");
            grilla.Columns.Add("Cantidad", "Cantidad");


            grilla.Rows.Add(txtCodigo.Text, cboTipoProducto.Text, txtCantidad.Text);

            LimpiarControles();


        }

        private void LimpiarControles()
        {
            txtCodigo.Text = "";
            cboTipoProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            btnRegistrar.Enabled = false;
            txtCodigo.Focus();
        }


    }
}
