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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

        }
        

     

        MySqlConnection objCon = new MySqlConnection("server=localhost; port=3307; User Id=root; database=sistema; password=usbw");



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          


            
                if (ValidaUsuario(txtusuario.Text, txtsenha.Text))
                {
                    this.DialogResult = DialogResult.OK;

                    this.Hide();

                Form f = new mPrincipal();
                f.Closed += (s, args) => this.Close();
                f.Show();
                }
                else
                {
                MessageBox.Show("Nome de usuário ou senha incorretos","Erro" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }


        private bool ValidaUsuario(string usuario, string senha)
        {
          
            int retorno = -1;
            string comando = "SELECT COUNT(*) FROM login WHERE usuario=@usuario AND senha=@senha";
           
            MySqlCommand cmd = new MySqlCommand(comando, objCon);
          
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
           
            objCon.Open();

            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            objCon.Close();

            return retorno > 0;

        }


        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmcadastro frm = new frmcadastro();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
