using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace EdisonEjemplo1
{
    public partial class frmAltaImpulsor : Form
    {
        public frmAltaImpulsor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            Impulsor Impu = new Impulsor(); 
            EdisonNegocio negocio = new EdisonNegocio();


            try
            {
                Impu.Nombre = txtboxNombre.Text;
                Impu.Codigo = txtboxCodigo.Text;
                Impu.DiametroExterior = int.Parse(nudDiametroExterior.Text);
                Impu.Eje = int.Parse(nudEje.Text);
                Impu.Anclaje = lblAnclaje.Text;
                Impu.Tipo = (catergoria)cboTipo.SelectedItem;

                negocio.Agregar(Impu);
                MessageBox.Show("Agregado exitosamente!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
