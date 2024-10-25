namespace AplicativoComMultiplasJanelas
{
    partial class FormNovoProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            numericUpDownPrecoCompra = new NumericUpDown();
            numericUpDownPrecoVenda = new NumericUpDown();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Fabricante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 3;
            label4.Text = "Preço de venda:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(124, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(179, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(124, 33);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(179, 23);
            textBoxFabricante.TabIndex = 5;
            // 
            // numericUpDownPrecoCompra
            // 
            numericUpDownPrecoCompra.DecimalPlaces = 2;
            numericUpDownPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecoCompra.Location = new Point(124, 62);
            numericUpDownPrecoCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrecoCompra.Name = "numericUpDownPrecoCompra";
            numericUpDownPrecoCompra.Size = new Size(179, 23);
            numericUpDownPrecoCompra.TabIndex = 6;
            numericUpDownPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownPrecoVenda
            // 
            numericUpDownPrecoVenda.DecimalPlaces = 2;
            numericUpDownPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecoVenda.Location = new Point(124, 91);
            numericUpDownPrecoVenda.Name = "numericUpDownPrecoVenda";
            numericUpDownPrecoVenda.Size = new Size(179, 23);
            numericUpDownPrecoVenda.TabIndex = 7;
            numericUpDownPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(147, 120);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(228, 120);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormNovoProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(311, 149);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(numericUpDownPrecoVenda);
            Controls.Add(numericUpDownPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private NumericUpDown numericUpDownPrecoCompra;
        private NumericUpDown numericUpDownPrecoVenda;
        private Button buttonOk;
        private Button buttonCancel;
    }
}