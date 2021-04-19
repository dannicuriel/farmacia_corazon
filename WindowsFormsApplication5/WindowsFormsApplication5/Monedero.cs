using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.Clases;


namespace WindowsFormsApplication5
{
    public partial class Monedero : Form
    {
        clsTranMonedero objTran = new clsTranMonedero();
        public Monedero()
        {
            InitializeComponent();
        }
        private void Monedero_Load(object sender, EventArgs e)
        {
            dtgMonedero.DataSource = objTran.cargaGridMonedero(0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objTran.idMonedero = txtmonedero.Text;
           dtgMonedero.DataSource = objTran.cargaGridMonedero(1);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean bflag = false;
            if (validaCampos())
            {
                objTran.idMonedero = txtmonedero.Text;
                objTran.Mon_puntos = txtpuntosMon.Text;
                /*
                objTran.ApPat = txtApPat.Text;
                objTran.ApMat = txtApMat.Text;
                objTran.Direccion = txtDireccion.Text;
                objTran.Telefono = txtTelefono.Text;
                objTran.Email = txtEmail.Text;
                objTran.RFC = txtRFC.Text;
                */
                if (objTran.insertarMonedero())
                {
                    lblStatus.BackColor = Color.Green;
                    limpiaDatosText();
                }
                else
                {
                    lblStatus.BackColor = Color.Red;
                }
               dtgMonedero.DataSource = objTran.cargaGridMonedero(0);
            }
            else
            {
                lblStatus.Text = "Intenta de nuevo";
                lblStatus.BackColor = Color.Pink;
            }
        }

             private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiaDatosText();
        }

        //--------------------------validar campos------------------------------//
        public void limpiaDatosText()
        {
            txtmonedero.Text = "";
            txtpuntosMon.Text = "";
            lblStatus.Text = "";


            txtmonedero.BackColor = Color.White;
            txtpuntosMon.BackColor = Color.White;
            lblStatus.BackColor = Color.White;
        }

        Boolean validaCampos()
        {
            Boolean bFlag = false;

            if (txtmonedero.Text.Equals(""))
            {
                txtmonedero.Focus();
                txtmonedero.BackColor = Color.Pink;
                bFlag = false;
            }
            else if (txtpuntosMon.Text.Equals(""))
            {
                txtpuntosMon.Focus();
                txtpuntosMon.BackColor = Color.Pink;
                bFlag = false;
            }
            
            else { bFlag = true; }
            return bFlag;
        }


        //--------------------------validar campos------------------------------//

       // -----------------------update------------------------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            objTran.idMonedero = txtmonedero.Text;
            objTran.Mon_puntos = txtpuntosMon.Text;
            objTran.updateMonedero();
            dtgMonedero.DataSource = objTran.cargaGridMonedero(0);
            limpiaDatosText();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objTran.idMonedero = txtmonedero.Text;
            objTran.DeleteMonedero();
            dtgMonedero.DataSource = objTran.cargaGridMonedero(0);
            limpiaDatosText();
        }

        private void dtgMonedero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgMonedero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmonedero.Text = Convert.ToString(dtgMonedero.CurrentRow.Cells[0].Value);
            txtpuntosMon.Text = Convert.ToString(dtgMonedero.CurrentRow.Cells[1].Value);
            
        }
    }
}

