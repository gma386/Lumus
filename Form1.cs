using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Lumus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();

 
        }

        private void LoadData()
        {
            // Cria uma instância do banco de dados
            var database = new database.Database();

            try
            {
                // Busca os dados no banco
                DataTable result = database.GetAll("pdd_pdt_fornecedor");

                // Cria uma lista para armazenar as 3 colunas
                List<(string Column1, string Column2, string Column3)> dataList = new List<(string, string, string)>();

                foreach (DataRow row in result.Rows)
                {
                    // Adiciona os valores de 3 colunas específicas na lista
                    dataList.Add((
                        row["id_pdd"].ToString(),
                        row["id_pdt"].ToString(),
                        row["pdt_valor"].ToString()
                    ));
                }

                // Opcional: Exibir os dados em um controle (como DataGridView)
                myDataGridView.DataSource = result; // Mostra a tabela inteira

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        //private void Form1_Load(object sender, EventArgs e) 
        //{

        //    string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=lumusdb";

        //    using (var conn = new NpgsqlConnection(connectionString))
        //    {
        //        conn.Open();



        //    }
        //}


    }
}
