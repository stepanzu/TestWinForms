using Model.Models;
using Model.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class ClienteRepository
    {
        private static string ws1 = "https://localhost:44336/api/";
        public static List<Cliente> GetAllClientes()
        {
            List<Cliente> lc = (List<Cliente>)RepositoryUtils.MakeRequest(string.Concat(ws1, "cliente/"), null, "GET", "application/json", typeof(List<Cliente>));
            return lc;
        }

        public static Cliente GetCliente(int id)
        {
            Cliente c = (Cliente)RepositoryUtils.MakeRequest(string.Concat(ws1, "cliente/", id), null, "GET", "application/json", typeof(Cliente));
            return c;
        }
    }
}
