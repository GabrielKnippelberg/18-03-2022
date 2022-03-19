using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisTDS06
{
    public partial class FormVendas : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\SisTDS06\\DbSis.mdf;Integrated Security=True");
        public FormVendas()
        {
            InitializeComponent();
        }
        public void CarregaCbxCliente()
        {
            string cli = "SELECT * FROM Cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "cpf";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }
        public void CarregaCbxProduto()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string pro = "SELECT Id, nome FROM [Produto	]";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            private void FormVenda_Load(object sender, EventArgs e)
            {
                if (cbxCliente.DisplayMember == "")
                {
                    cbxProduto.Enabled = false;
                    txtIdProduto.Enabled = false;
                    txtQuantidade.Enabled = false;
                    txtValor.Enabled = false;
                    dgvVenda.Enabled = false;
                    btnNovoItem.Enabled = false;
                    btnEditarItem.Enabled = false;
                    btnExcluirItem.Enabled = false;
                    txtTotal.Enabled = false;
                    btnFinalizarVenda.Enabled = false;
                }
                CarregaCbxCliente();
            }
            private void btnNovaVenda_Click(object sender, EventArgs e)
            {
                cbxProduto.Enabled = true;
                CarregaCbxProduto();
                txtIdProduto.Enabled = true;
                txtQuantidade.Enabled = true;
                txtValor.Enabled = true;
                dgvVenda.Enabled = true;
                btnNovoItem.Enabled = true;
                btnEditarItem.Enabled = true;
                btnExcluirItem.Enabled = true;
                txtTotal.Enabled = true;
                btnFinalizarVenda.Enabled = true;
                dgvVenda.Columns.Add("ID", "ID");
                dgvVenda.Columns.Add("Produto", "Produto");
                dgvVenda.Columns.Add("Quantidade", "Quantidade");
                dgvVenda.Columns.Add("Valor", "Valor");
                dgvVenda.Columns.Add("Total", "Total");
            }
            private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Produto	] WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtValor.Text = rd["valor"].ToString();
                    txtIdProduto.Text = rd["Id"].ToString();
                    txtQuantidade.Focus();
                    rd.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }

            private void btnNovoItem_Click(object sender, EventArgs e)
            {
                var repetido = false;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                {
                    if (txtIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                    {
                        repetido = true;
                    }
                }
                if (repetido == false)
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvVenda);
                    item.Cells[0].Value = txtIdProduto.Text;
                    item.Cells[1].Value = cbxProduto.Text;
                    item.Cells[2].Value = txtQuantidade.Text;
                    item.Cells[3].Value = txtValor.Text;
                    item.Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                    dgvVenda.Rows.Add(item);

                    cbxProduto.Text = "";
                    txtIdProduto.Text = "";
                    txtQuantidade.Text = "";
                    txtValor.Text = "";
                    decimal soma = 0;
                    foreach (DataGridViewRow dr in dgvVenda.Rows)
                        soma += Convert.ToDecimal(dr.Cells[4].Value);
                    txtTotal.Text = Convert.ToString(soma);
                }
                else
                {
                    MessageBox.Show("Item já esta listado na venda!", "Repetição", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];
                cbxProduto.Text = row.Cells[1].Value.ToString();
                txtIdProduto.Text = row.Cells[0].Value.ToString();
                txtQuantidade.Text = row.Cells[2].Value.ToString();
                txtValor.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
