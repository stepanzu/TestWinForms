namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewLineas = new System.Windows.Forms.DataGridView();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.labelGridClientes = new System.Windows.Forms.Label();
            this.labelGridPedidos = new System.Windows.Forms.Label();
            this.labelGridLineas = new System.Windows.Forms.Label();
            this.textBoxPageCliente = new System.Windows.Forms.TextBox();
            this.textBoxPageLinea = new System.Windows.Forms.TextBox();
            this.textBoxPagePedido = new System.Windows.Forms.TextBox();
            this.buttonPageBeforeCliente = new System.Windows.Forms.Button();
            this.buttonPageAfterCliente = new System.Windows.Forms.Button();
            this.buttonPageBeforeLinea = new System.Windows.Forms.Button();
            this.buttonPageAfterLinea = new System.Windows.Forms.Button();
            this.buttonPageBeforePedido = new System.Windows.Forms.Button();
            this.buttonPageAfterPedido = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gESTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(36, 84);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 29;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(561, 496);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.Tag = "Clientes";
            // 
            // dataGridViewLineas
            // 
            this.dataGridViewLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLineas.Location = new System.Drawing.Point(643, 392);
            this.dataGridViewLineas.Name = "dataGridViewLineas";
            this.dataGridViewLineas.RowHeadersWidth = 51;
            this.dataGridViewLineas.RowTemplate.Height = 29;
            this.dataGridViewLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLineas.Size = new System.Drawing.Size(376, 188);
            this.dataGridViewLineas.TabIndex = 1;
            this.dataGridViewLineas.Tag = "Lineas";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(643, 84);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.RowTemplate.Height = 29;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(376, 188);
            this.dataGridViewPedidos.TabIndex = 2;
            this.dataGridViewPedidos.Tag = "Pedidos";
            // 
            // labelGridClientes
            // 
            this.labelGridClientes.AutoSize = true;
            this.labelGridClientes.Location = new System.Drawing.Point(36, 50);
            this.labelGridClientes.Name = "labelGridClientes";
            this.labelGridClientes.Size = new System.Drawing.Size(61, 20);
            this.labelGridClientes.TabIndex = 3;
            this.labelGridClientes.Text = "Clientes";
            // 
            // labelGridPedidos
            // 
            this.labelGridPedidos.AutoSize = true;
            this.labelGridPedidos.Location = new System.Drawing.Point(643, 50);
            this.labelGridPedidos.Name = "labelGridPedidos";
            this.labelGridPedidos.Size = new System.Drawing.Size(61, 20);
            this.labelGridPedidos.TabIndex = 4;
            this.labelGridPedidos.Text = "Pedidos";
            // 
            // labelGridLineas
            // 
            this.labelGridLineas.AutoSize = true;
            this.labelGridLineas.Location = new System.Drawing.Point(643, 356);
            this.labelGridLineas.Name = "labelGridLineas";
            this.labelGridLineas.Size = new System.Drawing.Size(50, 20);
            this.labelGridLineas.TabIndex = 5;
            this.labelGridLineas.Text = "Lineas";
            // 
            // textBoxPageCliente
            // 
            this.textBoxPageCliente.Location = new System.Drawing.Point(133, 612);
            this.textBoxPageCliente.Name = "textBoxPageCliente";
            this.textBoxPageCliente.Size = new System.Drawing.Size(63, 27);
            this.textBoxPageCliente.TabIndex = 13;
            // 
            // textBoxPageLinea
            // 
            this.textBoxPageLinea.Location = new System.Drawing.Point(740, 610);
            this.textBoxPageLinea.Name = "textBoxPageLinea";
            this.textBoxPageLinea.Size = new System.Drawing.Size(63, 27);
            this.textBoxPageLinea.TabIndex = 14;
            // 
            // textBoxPagePedido
            // 
            this.textBoxPagePedido.Location = new System.Drawing.Point(740, 303);
            this.textBoxPagePedido.Name = "textBoxPagePedido";
            this.textBoxPagePedido.Size = new System.Drawing.Size(63, 27);
            this.textBoxPagePedido.TabIndex = 15;
            // 
            // buttonPageBeforeCliente
            // 
            this.buttonPageBeforeCliente.Location = new System.Drawing.Point(36, 610);
            this.buttonPageBeforeCliente.Name = "buttonPageBeforeCliente";
            this.buttonPageBeforeCliente.Size = new System.Drawing.Size(35, 29);
            this.buttonPageBeforeCliente.TabIndex = 16;
            this.buttonPageBeforeCliente.Text = "<";
            this.buttonPageBeforeCliente.UseVisualStyleBackColor = true;
            // 
            // buttonPageAfterCliente
            // 
            this.buttonPageAfterCliente.Location = new System.Drawing.Point(77, 610);
            this.buttonPageAfterCliente.Name = "buttonPageAfterCliente";
            this.buttonPageAfterCliente.Size = new System.Drawing.Size(35, 29);
            this.buttonPageAfterCliente.TabIndex = 17;
            this.buttonPageAfterCliente.Text = ">";
            this.buttonPageAfterCliente.UseVisualStyleBackColor = true;
            // 
            // buttonPageBeforeLinea
            // 
            this.buttonPageBeforeLinea.Location = new System.Drawing.Point(643, 610);
            this.buttonPageBeforeLinea.Name = "buttonPageBeforeLinea";
            this.buttonPageBeforeLinea.Size = new System.Drawing.Size(35, 29);
            this.buttonPageBeforeLinea.TabIndex = 18;
            this.buttonPageBeforeLinea.Text = "<";
            this.buttonPageBeforeLinea.UseVisualStyleBackColor = true;
            // 
            // buttonPageAfterLinea
            // 
            this.buttonPageAfterLinea.Location = new System.Drawing.Point(684, 610);
            this.buttonPageAfterLinea.Name = "buttonPageAfterLinea";
            this.buttonPageAfterLinea.Size = new System.Drawing.Size(35, 29);
            this.buttonPageAfterLinea.TabIndex = 19;
            this.buttonPageAfterLinea.Text = ">";
            this.buttonPageAfterLinea.UseVisualStyleBackColor = true;
            // 
            // buttonPageBeforePedido
            // 
            this.buttonPageBeforePedido.Location = new System.Drawing.Point(643, 301);
            this.buttonPageBeforePedido.Name = "buttonPageBeforePedido";
            this.buttonPageBeforePedido.Size = new System.Drawing.Size(35, 29);
            this.buttonPageBeforePedido.TabIndex = 20;
            this.buttonPageBeforePedido.Text = "<";
            this.buttonPageBeforePedido.UseVisualStyleBackColor = true;
            // 
            // buttonPageAfterPedido
            // 
            this.buttonPageAfterPedido.Location = new System.Drawing.Point(684, 301);
            this.buttonPageAfterPedido.Name = "buttonPageAfterPedido";
            this.buttonPageAfterPedido.Size = new System.Drawing.Size(35, 29);
            this.buttonPageAfterPedido.TabIndex = 21;
            this.buttonPageAfterPedido.Text = ">";
            this.buttonPageAfterPedido.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gESTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gESTIONToolStripMenuItem
            // 
            this.gESTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.gESTIONToolStripMenuItem.Name = "gESTIONToolStripMenuItem";
            this.gESTIONToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.gESTIONToolStripMenuItem.Text = "GESTION";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 665);
            this.Controls.Add(this.buttonPageAfterPedido);
            this.Controls.Add(this.buttonPageBeforePedido);
            this.Controls.Add(this.buttonPageAfterLinea);
            this.Controls.Add(this.buttonPageBeforeLinea);
            this.Controls.Add(this.buttonPageAfterCliente);
            this.Controls.Add(this.buttonPageBeforeCliente);
            this.Controls.Add(this.textBoxPagePedido);
            this.Controls.Add(this.textBoxPageLinea);
            this.Controls.Add(this.textBoxPageCliente);
            this.Controls.Add(this.labelGridLineas);
            this.Controls.Add(this.labelGridPedidos);
            this.Controls.Add(this.labelGridClientes);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.dataGridViewLineas);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelGridClientes;
        private Label labelGridPedidos;
        private Label labelGridLineas;
        private Button buttonAddCliente;
        private Button buttonAddPedido;
        private Button buttonAddLinea;
        private Button buttonDeleteCliente;
        private Button buttonDeleteLinea;
        private Button buttonDeletePedido;
        public DataGridView dataGridViewClientes;
        public DataGridView dataGridViewLineas;
        public DataGridView dataGridViewPedidos;
        public TextBox textBoxPageCliente;
        public TextBox textBoxPageLinea;
        public TextBox textBoxPagePedido;
        public Button buttonPageBeforeCliente;
        public Button buttonPageAfterCliente;
        public Button buttonPageBeforeLinea;
        public Button buttonPageAfterLinea;
        public Button buttonPageBeforePedido;
        public Button buttonPageAfterPedido;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem gESTIONToolStripMenuItem;
        public ToolStripMenuItem clientesToolStripMenuItem;
        public ToolStripMenuItem pedidosToolStripMenuItem;
    }
}