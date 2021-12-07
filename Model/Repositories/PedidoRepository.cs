using Model.Models;
using Model.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class PedidoRepository
    {
        private static string ws1 = "https://localhost:44336/api/";
        public static List<Pedido> GetAllPedidos()
        {
            List<Pedido> lc = (List<Pedido>)RepositoryUtils.MakeRequest(string.Concat(ws1, "pedido/"), null, "GET", "application/json", typeof(List<Pedido>));
            return lc;
        }

        public static List<Pedido> GetAllPedidos(int page, int pageNumber)
        {
            List<Pedido> lc = (List<Pedido>)RepositoryUtils.MakeRequest(string.Concat(ws1, "pedido/", page, "/", pageNumber), null, "GET", "application/json", typeof(List<Pedido>));
            return lc;
        }

        public static List<Pedido> GetAllPedidos(int page, int pageNumber, int? clienteId)
        {
            List<Pedido> lc = (List<Pedido>)RepositoryUtils.MakeRequest(string.Concat(ws1, "pedido/", page, "/", pageNumber, "/", clienteId), null, "GET", "application/json", typeof(List<Pedido>));
            return lc;
        }

        public static Pedido GetPedido(int id)
        {
            Pedido c = (Pedido)RepositoryUtils.MakeRequest(string.Concat(ws1, "pedido/", id), null, "GET", "application/json", typeof(Pedido));
            return c;
        }
    }
}
