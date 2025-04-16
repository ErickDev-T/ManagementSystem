using DataLayer;
using System.Diagnostics;

namespace BusinessLayer
{
    public class UserService
    {
        public string IniciarSesion(string user, string pass)
        {
            return UserDAO.GetRole(user, pass); // usa la capa de datos
        }
    }
}
