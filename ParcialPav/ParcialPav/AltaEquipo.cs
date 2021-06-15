using ParcialPav.Db._Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialPav
{
    public partial class AltaEquipo : Form
    {
        public AltaEquipo()
        {
            InitializeComponent();
        }

        private void AltaEquipo_Load(object sender, EventArgs e)
        {
            CargarFecha();
            ObtenerNumeroEquipo();
            CargarComboCategorias();
        }


        private void ObtenerNumeroEquipo() {

            txtNombreDeEquipo.Text = (DbEquipos.ObtenerCantidadquipos() + 1 ).ToString();
        }
        private void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void CargarComboCategorias()
        {
            DataTable tabla = DbCb.ObtenerCbCategorias();
            cmbCategorias.DataSource = tabla;
            cmbCategorias.DisplayMember = "Document_type";
            cmbCategorias.ValueMember = "Id";
            cmbCategorias.SelectedIndex = -1;
        }

        private void CargarComboPosicion()
        {
            DataTable tabla = DbCb.ObtenerCbPosiciones();
            cmbPosicion.DataSource = tabla;
            cmbPosicion.DisplayMember = "Document_type";
            cmbPosicion.ValueMember = "Id";
            cmbPosicion.SelectedIndex = -1;
        }

        private void ObtenerJugador()
        {
            try
            {
                DataTable rta = Jugador.ObtenerJugadoresxid(int.Parse(txtNroJugador.Text));
                if (rta.Rows.Count > 0 )
                {
                    txtNroJugador.Text = rta.Rows[0][1].ToString();

                }
                else
                {
                    MessageBox.Show("Jugador inexistente");
                    txtNroJugador.Focus();
                    txtNroJugador.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            ObtenerJugador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridGame.Rows.Add(txtNroJugador.Text,txtUserGamer,btnAgregarJugador, cmbPosicion.SelectedItem);
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> ListaJugadores = new List<int>;
            for (int i = 0; i < GridGame.Rows.Count; i++)
            {
                ListaJugadores.Add(int.Parse(GridGame.Rows[i].Cells[0].Value.ToString()));
            }
    }
}
