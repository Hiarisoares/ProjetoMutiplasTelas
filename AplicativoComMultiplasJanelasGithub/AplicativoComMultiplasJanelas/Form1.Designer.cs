namespace AplicativoComMultiplasJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionarProduto = new Button();
            buttonDeletarProduto = new Button();
            dataGridView1 = new DataGridView();
            buttonVerProdutos = new Button();
            buttonVerClientes = new Button();
            buttonVerFornecedores = new Button();
            buttonVerCompras = new Button();
            buttonVerVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonDeletarFornecedor = new Button();
            buttonNovoCliente = new Button();
            buttonDeletarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.Location = new Point(12, 56);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(113, 23);
            buttonAdicionarProduto.TabIndex = 0;
            buttonAdicionarProduto.Text = "Novo Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.Location = new Point(12, 80);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(113, 23);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = true;
            buttonDeletarProduto.Click += buttonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 416);
            dataGridView1.TabIndex = 2;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            // 
            // buttonVerProdutos
            // 
            buttonVerProdutos.Location = new Point(12, 12);
            buttonVerProdutos.Name = "buttonVerProdutos";
            buttonVerProdutos.Size = new Size(113, 41);
            buttonVerProdutos.TabIndex = 3;
            buttonVerProdutos.Text = "Produtos";
            buttonVerProdutos.UseVisualStyleBackColor = true;
            buttonVerProdutos.Click += buttonVerProdutos_Click;
            // 
            // buttonVerClientes
            // 
            buttonVerClientes.Location = new Point(250, 12);
            buttonVerClientes.Name = "buttonVerClientes";
            buttonVerClientes.Size = new Size(113, 41);
            buttonVerClientes.TabIndex = 4;
            buttonVerClientes.Text = "Clientes";
            buttonVerClientes.UseVisualStyleBackColor = true;
            buttonVerClientes.Click += buttonVerClientes_Click;
            // 
            // buttonVerFornecedores
            // 
            buttonVerFornecedores.Location = new Point(131, 12);
            buttonVerFornecedores.Name = "buttonVerFornecedores";
            buttonVerFornecedores.Size = new Size(113, 41);
            buttonVerFornecedores.TabIndex = 4;
            buttonVerFornecedores.Text = "Fornecedores";
            buttonVerFornecedores.UseVisualStyleBackColor = true;
            buttonVerFornecedores.Click += buttonVerFornecedores_Click;
            // 
            // buttonVerCompras
            // 
            buttonVerCompras.Location = new Point(369, 12);
            buttonVerCompras.Name = "buttonVerCompras";
            buttonVerCompras.Size = new Size(113, 41);
            buttonVerCompras.TabIndex = 4;
            buttonVerCompras.Text = "Compras";
            buttonVerCompras.UseVisualStyleBackColor = true;
            buttonVerCompras.Click += buttonVerCompras_Click;
            // 
            // buttonVerVendas
            // 
            buttonVerVendas.Location = new Point(488, 12);
            buttonVerVendas.Name = "buttonVerVendas";
            buttonVerVendas.Size = new Size(113, 41);
            buttonVerVendas.TabIndex = 4;
            buttonVerVendas.Text = "Vendas";
            buttonVerVendas.UseVisualStyleBackColor = true;
            buttonVerVendas.Click += buttonVerVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.Location = new Point(131, 56);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(113, 23);
            buttonAdicionarFornecedor.TabIndex = 0;
            buttonAdicionarFornecedor.Text = "Novo Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = true;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.Location = new Point(131, 80);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(113, 23);
            buttonDeletarFornecedor.TabIndex = 1;
            buttonDeletarFornecedor.Text = "Deletar Fornecedor";
            buttonDeletarFornecedor.UseVisualStyleBackColor = true;
            buttonDeletarFornecedor.Click += buttonDeletarFornecedor_Click;
            // 
            // buttonNovoCliente
            // 
            buttonNovoCliente.Location = new Point(250, 56);
            buttonNovoCliente.Name = "buttonNovoCliente";
            buttonNovoCliente.Size = new Size(113, 23);
            buttonNovoCliente.TabIndex = 5;
            buttonNovoCliente.Text = "Novo Cliente";
            buttonNovoCliente.UseVisualStyleBackColor = true;
            buttonNovoCliente.Click += buttonNovoCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.Location = new Point(250, 80);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(113, 23);
            buttonDeletarCliente.TabIndex = 6;
            buttonDeletarCliente.Text = "Deletar Cliente";
            buttonDeletarCliente.UseVisualStyleBackColor = true;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 537);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonNovoCliente);
            Controls.Add(buttonVerVendas);
            Controls.Add(buttonVerCompras);
            Controls.Add(buttonVerFornecedores);
            Controls.Add(buttonVerClientes);
            Controls.Add(buttonVerProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeletarFornecedor);
            Controls.Add(buttonDeletarProduto);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonAdicionarProduto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
        private Button buttonDeletarProduto;
        private DataGridView dataGridView1;
        private Button buttonVerProdutos;
        private Button buttonVerClientes;
        private Button buttonVerFornecedores;
        private Button buttonVerCompras;
        private Button buttonVerVendas;
        private Button buttonAdicionarFornecedor;
        private Button buttonDeletarFornecedor;
        private Button buttonNovoCliente;
        private Button buttonDeletarCliente;
    }
}
