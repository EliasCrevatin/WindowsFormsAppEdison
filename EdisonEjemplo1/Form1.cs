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
    public partial class Form1 : Form
    {
        private List<Impulsor> listaImpulsor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            EdisonNegocio negocio = new EdisonNegocio();
            try
            {

                listaImpulsor = negocio.listar();
                DgvImpulsores.DataSource = listaImpulsor;
                DgvImpulsores.Columns["UrlImagen"].Visible = false;
                DgvImpulsores.Columns["ID_Categoria"].Visible = false;
                CargarImagen(listaImpulsor[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvImpulsores_SelectionChanged(object sender, EventArgs e)
        {
            Impulsor seleccionado = (Impulsor)DgvImpulsores.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagen);
        }



        private void CargarImagen(string imagen)
        {
            try
            {
                PboxImpulsores.Load(imagen);
            }
            catch (Exception)
            {

                PboxImpulsores.Load("https://media.istockphoto.com/vectors/image-preview-icon-picture-placeholder-for-website-or-uiux-design-vector-id1222357475?k=20&m=1222357475&s=612x612&w=0&h=jPhUdbj_7nWHUp0dsKRf4DMGaHiC16kg_FSjRRGoZEI=");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaImpulsor Alta = new frmAltaImpulsor();
            Alta.ShowDialog();
            cargar();
        }

       
    }
}

