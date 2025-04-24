using MySQLLab.Dados;

namespace MySQLLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dados.DBConnection.GetConnection().ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            DBConnection dados = new DBConnection();

            dados.Create(Convert.ToInt32(txtId.Text), txtNome.Text, txtEmail.Text, txtSenha.Text);
            MessageBox.Show("Cadastrado com sucesso!");
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DBConnection dados = new DBConnection();
            dados.Delete(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Deletado com sucesso!");
            txtId.Clear();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se todos os campos estão preenchidos
                if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNome.Text) &&
                    !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtSenha.Text))
                {
                    DBConnection dados = new DBConnection();

                    // Chama o método Update e verifica o retorno
                    bool isUpdated = dados.Update(Convert.ToInt32(txtId.Text), txtNome.Text, txtEmail.Text, txtSenha.Text);

                    if (isUpdated)
                    {
                        MessageBox.Show("Atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações!");
                    }

                    // Limpa os campos
                    txtId.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos para atualizar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcionário: " + ex.Message);
            }
        }

    }
}

