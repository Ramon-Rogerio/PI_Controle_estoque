using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto1
{
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            if (txtsenhacadastro.Text == txtrepetir.Text)
            {

                //abrir banco de dados 
                MySqlConnection objCon = new MySqlConnection("server=localhost; port=3307; User Id=root; database=sistema; password=usbw");

                objCon.Open();
                //comando sql para inserir dados na tabela 
                MySqlCommand objCmd = new MySqlCommand("insert into login (usuario, senha) values (?,?)", objCon);

                //paramentros do comado sql
                objCmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 100).Value = txtnomedaempresa.Text;
                objCmd.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtsenhacadastro.Text;


                //Comando para execultar a query

                objCmd.ExecuteNonQuery();
                objCon.Close();

                MessageBox.Show("Cadastro efetuado com sucesso");

                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {

                MessageBox.Show("As senhas devem ser identicas");

            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            //TextBox clear code
            txtnomedaempresa.Text = "";
            txtrepetir.Text = "";
            txtsenhacadastro.Text = "";

        }

        private void frmcadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnVol_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void txtsenhacadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrepetir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
