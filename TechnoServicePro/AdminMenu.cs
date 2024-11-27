using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechnoServicePro
{
    public partial class AdminMenu : Form
    {
        private string connectionString = @"Data Source=DESKTOP-DFJ77GS;Initial Catalog=Techno;Integrated Security=True;TrustServerCertificate=True;";
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            
            this.заявкиTableAdapter.Fill(this.technoDataSet.Заявки);

        }
        // Загрузка данных из базы данных в DataGridView
        private void LoadData()
        {
            string query = "SELECT Код_заявки, Дата_заявки, Оборудование, Код_неисправности, Описание_проблемы, Код_клиента, Статус, Ответственный_исполнитель FROM Заявки";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Проверяем наличие столбца "Код_заявки" в DataTable
                if (dataTable.Columns.Contains("Код_заявки"))
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Ошибка: столбец 'Код_заявки' не найден в данных.");
                }
            }
        }

        // Добавление новой заявки
        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string equipment = textBox1.Text; // Оборудование
            string faultCode = textBox2.Text; // Код неисправности
            string problemDescription = textBox3.Text; // Описание проблемы
            int clientCode = int.TryParse(textBox4.Text, out int clientCodeParsed) ? clientCodeParsed : 0; // Код клиента
            string status = textBox5.Text; // Статус заявки
            string responsible = textBox6.Text; // Ответственный исполнитель

            // Проверка на обязательные поля
            if (string.IsNullOrEmpty(equipment) || string.IsNullOrEmpty(faultCode) || string.IsNullOrEmpty(problemDescription) || clientCode == 0 || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // SQL-запрос для добавления новой заявки
            string query = "INSERT INTO Заявки (Оборудование, Код_неисправности, Описание_проблемы, Код_клиента, Статус, Ответственный_исполнитель, Дата_заявки) " +
                           "VALUES (@Оборудование, @Код_неисправности, @Описание_проблемы, @Код_клиента, @Статус, @Ответственный_исполнитель, @Дата_заявки)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Оборудование", equipment);
                command.Parameters.AddWithValue("@Код_неисправности", faultCode);
                command.Parameters.AddWithValue("@Описание_проблемы", problemDescription);
                command.Parameters.AddWithValue("@Код_клиента", clientCode);
                command.Parameters.AddWithValue("@Статус", status);
                command.Parameters.AddWithValue("@Ответственный_исполнитель", responsible);
                command.Parameters.AddWithValue("@Дата_заявки", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }

            // Обновляем данные после добавления
            LoadData();
        }

        // Удаление заявки
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int requestId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Код_заявки"].Value);

                // SQL-запрос для удаления заявки
                string query = "DELETE FROM Заявки WHERE Код_заявки = @Код_заявки";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Код_заявки", requestId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Обновляем данные после удаления
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.");
            }
        }

        // Обновление заявки
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int requestId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Код_заявки"].Value);
                string equipment = textBox1.Text;
                string faultCode = textBox2.Text;
                string problemDescription = textBox3.Text;
                int clientCode = int.TryParse(textBox4.Text, out int clientCodeParsed) ? clientCodeParsed : 0;
                string status = textBox5.Text;
                string responsible = textBox6.Text;

                // SQL-запрос для обновления заявки
                string query = "UPDATE Заявки SET Оборудование = @Оборудование, Код_неисправности = @Код_неисправности, " +
                               "Описание_проблемы = @Описание_проблемы, Код_клиента = @Код_клиента, Статус = @Статус, " +
                               "Ответственный_исполнитель = @Ответственный_исполнитель WHERE Код_заявки = @Код_заявки";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Оборудование", equipment);
                    command.Parameters.AddWithValue("@Код_неисправности", faultCode);
                    command.Parameters.AddWithValue("@Описание_проблемы", problemDescription);
                    command.Parameters.AddWithValue("@Код_клиента", clientCode);
                    command.Parameters.AddWithValue("@Статус", status);
                    command.Parameters.AddWithValue("@Ответственный_исполнитель", responsible);
                    command.Parameters.AddWithValue("@Код_заявки", requestId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Обновляем данные после обновления
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите заявку для обновления.");
            }
        }

        // Сохранение изменений в базу
        private void button4_Click(object sender, EventArgs e)
        {
            LoadData(); // Обновление данных из базы
        }
    
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
