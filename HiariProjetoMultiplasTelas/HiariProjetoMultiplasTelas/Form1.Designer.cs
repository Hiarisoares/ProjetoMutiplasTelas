namespace HiariProjetoMultiplasTelas
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
            listBoxProdutos = new ListBox();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.Location = new Point(12, 25);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(119, 23);
            buttonAdicionarProduto.TabIndex = 0;
            buttonAdicionarProduto.Text = "Novo Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.Location = new Point(173, 25);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(112, 23);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = true;
            buttonDeletarProduto.Click += button2_Click;
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 15;
            listBoxProdutos.Location = new Point(12, 68);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(384, 214);
            listBoxProdutos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxProdutos);
            Controls.Add(buttonDeletarProduto);
            Controls.Add(buttonAdicionarProduto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
        private Button buttonDeletarProduto;
        private ListBox listBoxProdutos;
    }
}
