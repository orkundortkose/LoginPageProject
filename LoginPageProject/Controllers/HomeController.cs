using LoginPageProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;


namespace LoginPageProject.Controllers
{
    public class HomeController : Controller
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=LoginDb;Integrated Security=true";

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @UserName AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (IsDatabaseUser(username) && ValidateUser(username, password))
            {
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                
                ViewBag.Error = "Geçersiz kullanıcı adı veya şifre.";
                return View();
            }
        }

        private bool CheckIfUserExistsInDatabase(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool IsDatabaseUser(string username)
        {

            return CheckIfUserExistsInDatabase(username);
        }

        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult FAQ()
        {

            return View();
        }
    }
}
