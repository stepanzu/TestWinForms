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
            //throw new NotImplementedException();
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
                clientesList = ClienteRepository.GetAllClientes();
                this.mainForm.dataGridViewClientes.DataSource = clientesList;
                this.mainForm.dataGridViewClientes.AutoResizeColumns();
                //this.mainForm.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.mainForm.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        public void RefreshGrids(object? sender, DataGridViewCellEventArgs e) 
        {
            string tagValue = (string)((DataGridView)sender).Tag;

            int selectedId = 0;
            if (tagValue == "Clientes")
            {
                selectedId = Convert.ToInt32(this.mainForm.dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);

            }
            else if (tagValue == "Pedidos") 
            {
                selectedId = Convert.ToInt32(this.mainForm.dataGridViewPedidos.SelectedRows[0].Cells["Id"].Value);

            }

            MessageBox.Show("TAG=> " + tagValue + " ID=> " + selectedId.ToString());



        }

        
    }
}
