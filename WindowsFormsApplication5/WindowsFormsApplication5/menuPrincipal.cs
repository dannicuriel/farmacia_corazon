using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("bye", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();


            Ventas ven = new Ventas();
            ven.Show();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bntServicios_Click(object sender, EventArgs e)
        {

            this.Hide();


            Servicios serv = new Servicios();
            serv.Show();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            this.Hide();


            Pacientes pac = new Pacientes();
            pac.Show();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnMonedero_Click(object sender, EventArgs e)
        {
                        
            Monedero mon = new Monedero();
            this.Hide();
            mon.Show();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();


           consultas cons = new consultas();
            cons.Show();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();


            Inventario inv = new Inventario();
            inv.Show();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
