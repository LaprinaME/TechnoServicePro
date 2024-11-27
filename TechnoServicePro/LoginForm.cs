using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechnoServicePro
{
    public partial class LoginForm : Form
    {
        // Строка подключения к базе данных
        private string connectionString = @"Data Source=DESKTOP-DFJ77GS;Initial Catalog=Techno;Integrated Security=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // Действия при изменении текста в поле usernameTextBox
        }

        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // Действия при изменении текста в поле passwordTextBox
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string phone = usernameTextBox.Text; // Логин - Телефон
            string email = passwordTextBox.Text; // Пароль - Email

            // Проверка логина и пароля
            string roleCode = AuthenticateUser(phone, email);

            if (!string.IsNullOrEmpty(roleCode))
            {
                MessageBox.Show("Авторизация успешна.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Перенаправление в зависимости от роли
                Form nextForm = GetNextFormByRole(roleCode);
                if (nextForm != null)
                {
                    nextForm.Show();
                    this.Hide(); // Скрыть текущую форму
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Аутентификация пользователя через таблицу "Клиенты"
        private string AuthenticateUser(string phone, string email)
        {
            string query = "SELECT Код_роли FROM Клиенты WHERE Телефон = @phone AND Email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);

                    // Получение кода роли пользователя
                    object result = command.ExecuteScalar();

                    // Если результат не пустой, возвращаем роль пользователя
                    return result?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        // Получение формы в зависимости от роли пользователя
        private Form GetNextFormByRole(string roleCode)
        {
            switch (roleCode)
            {
                case "1": // Администратор
                    return new AdminMenu();
                case "2": // Работник
                    return new WorkerMenu();
                default:
                    MessageBox.Show("Неизвестный код роли", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }
    }
}
