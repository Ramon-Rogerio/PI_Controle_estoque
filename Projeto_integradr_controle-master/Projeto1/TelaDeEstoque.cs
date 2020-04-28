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
    public partial class mPrincipal : Form
    {
        public mPrincipal()
        {
            InitializeComponent();
        }

        public void test() {

            string config = "server=localhost; port=3307; User Id=root; database=sistema; password=usbw";

            string query = string.Format("SELECT * FROM {0}", "cadastro");

            MySqlConnection conexao = new MySqlConnection(config);

            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvpro.DataSource = data;



        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        internal static void show()
        {
  
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            Form f = new frmLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblcod.Visible = false;
            txtcod.Visible = false;
            btnsalvar.Visible = true;
            btncancelar.Visible = true;
            btnDel.Visible = false;
            txtQuant.Visible = true;
            btnDel.Visible = false;
            label1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncan_Click(object sender, EventArgs e)
        {
            lblName.Visible = false;
            txtName.Visible = false;
            lblcod.Visible = true;
            txtcod.Visible = true;
            btnsalvar.Visible = false;
            btncancelar.Visible = true;
            btnDel.Visible = true;
            txtQuant.Visible = false;
            label1.Visible = false;


                //abrir banco de dados 
                MySqlConnection objCon = new MySqlConnection("server=localhost; port=3307; User Id=root; database=sistema; password=usbw");

                objCon.Open();

                MySqlCommand objCmd = new MySqlCommand("delete from cadastro where codigo = ?;",objCon);

                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = txtcod.Text;

                objCmd.CommandType = CommandType.Text;
                objCmd.ExecuteNonQuery();

                MessageBox.Show("Registro removido com sucesso");


            


        }

        private void editarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = false;
            txtName.Visible = false;
            lblcod.Visible = true;
            txtcod.Visible = true;
            btnsalvar.Visible = false;
            btncancelar.Visible = true;
            btnDel.Visible = true;
            txtQuant.Visible = false;
            label1.Visible = false;
        }

        private void despacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblcod.Visible = true;
            txtcod.Visible = true;
            btnsalvar.Visible = false;
            btncancelar.Visible = true;
            btnDel.Visible = true;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //abrir banco de dados 
            MySqlConnection objCon = new MySqlConnection("server=localhost; port=3307; User Id=root; database=sistema; password=usbw");

            objCon.Open();
            //comando sql para inserir dados na tabela 
            MySqlCommand objCmd = new MySqlCommand("insert into cadastro (codigo,quantidade, produto) values (null,?,?)", objCon);

            //paramentros do comado sql
            objCmd.Parameters.Add("@quantidade", MySqlDbType.VarChar, 10).Value = txtQuant.Text;
            objCmd.Parameters.Add("@produto", MySqlDbType.VarChar, 100).Value = txtName.Text;
           


            //Comando para execultar a query

            objCmd.ExecuteNonQuery();
            objCon.Close();

            MessageBox.Show("Cadastro do Produto efetuado com sucesso");

        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmLogin ();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            test();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
