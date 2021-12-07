using Controller.Interfaces;
using Model.Models;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Controller.Controllers
{
    public class MainController : IController
    {
        private MainForm mainForm = new MainForm();

        private List<Cliente> clientesList = new List<Cliente>();
        private List<Pedido> pedidosList = new List<Pedido>();
        private List<LineaPedido> lineasList = new List<LineaPedido>();
        private int gridMaxRows = 10;

        public void init()
        {
            InitListeners();
            PrepareDataGrids();
            PopulateInitialDataGrids();
            HideRelationalFields();
            RunApplication();
        }

        public void RunApplication()
        {
            Application.Run(this.mainForm);
        }

        public void InitListeners()
        {

            this.mainForm.dataGridViewClientes.CellClick += new DataGridViewCellEventHandler(RefreshGrids);
            this.mainForm.dataGridViewPedidos.CellClick += new DataGridViewCellEventHandler(RefreshGrids);
            this.mainForm.buttonPageBeforeCliente.Click += new EventHandler(DownPage);
            this.mainForm.buttonPageAfterCliente.Click += new EventHandler(UpPage);
        }

        public void PrepareDataGrids()
        {
            this.mainForm.dataGridViewClientes.MultiSelect = false;
            this.mainForm.dataGridViewClientes.ReadOnly = true;
            this.mainForm.dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainForm.dataGridViewClientes.RowHeadersVisible = false;
            this.mainForm.dataGridViewClientes.AllowUserToResizeColumns = true;
            this.mainForm.dataGridViewClientes.AllowUserToResizeRows = false;
            //this.mainForm.dataGridViewClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            this.mainForm.dataGridViewPedidos.MultiSelect = false;
            this.mainForm.dataGridViewPedidos.ReadOnly = true;
            this.mainForm.dataGridViewPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainForm.dataGridViewPedidos.RowHeadersVisible = false;
            this.mainForm.dataGridViewPedidos.AllowUserToResizeColumns = true;
            this.mainForm.dataGridViewPedidos.AllowUserToResizeRows = false;

            this.mainForm.dataGridViewLineas.MultiSelect = false;
            this.mainForm.dataGridViewLineas.ReadOnly = true;
            this.mainForm.dataGridViewLineas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainForm.dataGridViewLineas.RowHeadersVisible = false;
            this.mainForm.dataGridViewLineas.AllowUserToResizeColumns = true;
            this.mainForm.dataGridViewLineas.AllowUserToResizeRows = false;

        }

        public void HideRelationalFields()
        {
            this.mainForm.dataGridViewClientes.Columns["Pedidos"].Visible = false;
        }

        public void PopulateInitialDataGrids()
        {
            this.mainForm.dataGridViewClientes.DataSource = null;
            this.mainForm.dataGridViewPedidos.DataSource = null;
            this.mainForm.dataGridViewLineas.DataSource = null;

            this.mainForm.dataGridViewClientes.ClearSelection();
            this.mainForm.dataGridViewPedidos.ClearSelection();
            this.mainForm.dataGridViewLineas.ClearSelection();

            try 
            {
                FillDataGrid(1, gridMaxRows, "Clientes");
                //clientesList = ClienteRepository.GetAllClientes(1, gridMaxRows);
                //this.mainForm.dataGridViewClientes.DataSource = clientesList;
                //this.mainForm.dataGridViewClientes.AutoResizeColumns();
                //this.mainForm.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void FillDataGrid(int page, int pageNumber, string tag, int? selectedId = null) 
        {
            switch (tag) 
            {
                case "Clientes":

                    this.mainForm.dataGridViewClientes.DataSource = null;
                    this.mainForm.dataGridViewClientes.ClearSelection();

                    clientesList = ClienteRepository.GetAllClientes(page, pageNumber);
                    this.mainForm.dataGridViewClientes.DataSource = clientesList;
                    this.mainForm.dataGridViewClientes.AutoResizeColumns();
                    this.mainForm.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Pedidos":

                    pedidosList = PedidoRepository.GetAllPedidos(1, gridMaxRows, selectedId);
                    this.mainForm.dataGridViewPedidos.DataSource = pedidosList;
                    this.mainForm.dataGridViewPedidos.AutoResizeColumns();
                    this.mainForm.dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "LineasPedidos":
                    lineasList = LineaPedidoRepository.GetAllLineasPedidos(1, gridMaxRows, selectedId);
                    this.mainForm.dataGridViewLineas.DataSource = lineasList;
                    this.mainForm.dataGridViewLineas.AutoResizeColumns();
                    this.mainForm.dataGridViewLineas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                default:

                    break;
            }

        }

        public void RefreshGrids(object? sender, DataGridViewCellEventArgs e) 
        {
            string tagValue = (string)((DataGridView)sender).Tag;

            int selectedId = 0;
            if (tagValue == "Clientes")
            {
                selectedId = Convert.ToInt32(this.mainForm.dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);

                this.mainForm.dataGridViewPedidos.DataSource = null;
                this.mainForm.dataGridViewPedidos.ClearSelection();
                this.mainForm.dataGridViewLineas.DataSource = null;
                this.mainForm.dataGridViewLineas.ClearSelection();

                FillDataGrid(1, gridMaxRows, "Pedidos", selectedId);

            }
            else if (tagValue == "Pedidos") 
            {
                selectedId = Convert.ToInt32(this.mainForm.dataGridViewPedidos.SelectedRows[0].Cells["Id"].Value);

                this.mainForm.dataGridViewLineas.DataSource = null;
                this.mainForm.dataGridViewLineas.ClearSelection();

                FillDataGrid(1, gridMaxRows, "LineasPedidos", selectedId);

            }

            //MessageBox.Show("TAG=> " + tagValue + " ID=> " + selectedId.ToString());



        }
        private void DownPage(object sender, System.EventArgs e)
        {
            //this.textBoxPage.Text = (Convert.ToInt32(this.textBoxPage.Text) + 1).ToString();
            //FillDataGrid(Convert.ToInt32(this.textBoxPage.Text), Results, this.textBoxOrderBy.Text);
        }
        private void UpPage(object sender, System.EventArgs e)
        {
            //this.textBoxPage.Text = (Convert.ToInt32(this.textBoxPage.Text) + 1).ToString();
            //FillDataGrid(Convert.ToInt32(this.textBoxPage.Text), Results, this.textBoxOrderBy.Text);
        }


    }
}
