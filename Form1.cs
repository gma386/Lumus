using Npgsql;

namespace Lumus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            btn_connection.Click += btn_connection_Click;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=lumusdb";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();



            }
        }


    }
}
