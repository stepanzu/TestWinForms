using Model.Models;
using Model.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class LineaPedidoRepository
    {
        private static string ws1 = "https://localhost:44336/api/";
        public static List<LineaPedido> GetAllLineasPedidos()
        {
            List<LineaPedido> lc = (List<LineaPedido>)RepositoryUtils.MakeRequest(string.Concat(ws1, "lineaPedido/"), null, "GET", "application/json", typeof(List<LineaPedido>));
            return lc;
        }

        public static List<LineaPedido> GetAllLineasPedidos(int page, int pageNumber)
        {
            List<LineaPedido> lc = (List<LineaPedido>)RepositoryUtils.MakeRequest(string.Concat(ws1, "lineaPedido/", page, "/", pageNumber), null, "GET", "application/json", typeof(List<LineaPedido>));
            return lc;
        }

        public static List<LineaPedido> GetAllLineasPedidos(int page, int pageNumber, int? pedidoId)
        {
            List<LineaPedido> lc = (List<LineaPedido>)RepositoryUtils.MakeRequest(string.Concat(ws1, "lineaPedido/", page, "/", pageNumber, "/", pedidoId), null, "GET", "application/json", typeof(List<LineaPedido>));
            return lc;
        }

        public static LineaPedido GetLineaPedido(int id)
        {
            LineaPedido c = (LineaPedido)RepositoryUtils.MakeRequest(string.Concat(ws1, "lineaPedido/", id), null, "GET", "application/json", typeof(LineaPedido));
            return c;
        }
    }
}
