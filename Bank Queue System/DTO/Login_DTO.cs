using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Queue_System.DTO
{
    class Login_DTO
    {
        private int id;
        private string login_name;
        private string password;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Login_name { get => login_name; set => login_name = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
    }
}
