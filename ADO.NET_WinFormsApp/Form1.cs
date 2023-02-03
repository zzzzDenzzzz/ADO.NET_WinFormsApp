using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ADO.NET_WinFormsApp
{
    public partial class Form1 : Form
    {
        string _connectionString;
        DataSet _dataSet;
        SqlDataAdapter _dataAdapter;

        public Form1()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
            _dataSet = new DataSet();
            _dataAdapter = new SqlDataAdapter();
            TestConnection();
            GetData();
        }

        void GetData()
        {
            _dataSet = new DataSet();
            var getAllTablesText = "SELECT * FROM Goods; SELECT * FROM Suppliers; SELECT * FROM Deliveries";
            var connection = new SqlConnection(_connectionString);
            _dataAdapter = new SqlDataAdapter(getAllTablesText, connection);
            _dataAdapter.TableMappings.Add("Table", "Goods");
            _dataAdapter.TableMappings.Add("Table1", "Suppliers");
            _dataAdapter.TableMappings.Add("Table2", "Deliveries");
            _dataAdapter.Fill(_dataSet);
        }

        void TestConnection()
        {
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Подключение установлено");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                // очищаем DataSet
                _dataSet = new DataSet();

                // создаем подключение
                var connection = new SqlConnection(_connectionString);

                // берем текст команды из textBox
                var commandText = txtCommand.Text;

                // создаем адаптер с помощью подключения, и текста команды
                // для выборки данных
                _dataAdapter = new SqlDataAdapter(commandText, connection);

                // обновляем Grid
                mainGrid.DataSource = null;

                // заполняем DataSet
                _dataAdapter.Fill(_dataSet, "authors");

                // показываем таблицу из DataSet
                mainGrid.DataSource = _dataSet.Tables["authors"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            var commandBuilder = new SqlCommandBuilder(_dataAdapter);
            _dataAdapter.Update(_dataSet);

            //Debug.WriteLine(commandBuilder.GetInsertCommand().CommandText);
            //Debug.WriteLine(commandBuilder.GetUpdateCommand().CommandText);
            //Debug.WriteLine(commandBuilder.GetDeleteCommand().CommandText);

            MessageBox.Show("Данные обновлены");
            GetData();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = _dataSet.Tables["Goods"];
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = _dataSet.Tables["Suppliers"];
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = _dataSet.Tables["Deliveries"];
        }

        private void btnMaxAmountGoods_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            ExecuteQuery("SELECT TOP 1 * FROM Deliveries ORDER BY Amount DESC");
            mainGrid.DataSource = _dataSet.Tables[0];
        }

        void ExecuteQuery(string query)
        {
            _dataSet = new DataSet();
            var connection = new SqlConnection(_connectionString);
            _dataAdapter = new SqlDataAdapter(query, connection);
            _dataAdapter.Fill(_dataSet);
        }

        private void btnMinAmountGoods_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            ExecuteQuery("SELECT TOP 1 * FROM Deliveries ORDER BY Amount");
            mainGrid.DataSource = _dataSet.Tables[0];
        }
    }
}