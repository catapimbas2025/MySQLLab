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
    }
}
