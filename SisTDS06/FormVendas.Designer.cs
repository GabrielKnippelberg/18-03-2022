namespace SisTDS06
{
    partial class FormVendas
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
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(12, 9);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(104, 15);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido / Venda";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(15, 27);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(157, 21);
            this.txtPedido.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 51);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 15);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 98);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(57, 15);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(15, 162);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(187, 21);
            this.txtQuantidade.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 144);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 15);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(15, 253);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(231, 21);
            this.txtIdProduto.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 235);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 15);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id Produto";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(15, 204);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(216, 21);
            this.txtPreco.TabIndex = 11;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 186);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(44, 15);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço";
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(12, 288);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(652, 120);
            this.dgvVenda.TabIndex = 12;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Cyan;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Location = new System.Drawing.Point(238, 25);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(80, 23);
            this.btnLocalizar.TabIndex = 13;
            this.btnLocalizar.Text = "Localilzar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.Yellow;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(223, 162);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(141, 23);
            this.btnAdicionarProduto.TabIndex = 14;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.BackColor = System.Drawing.Color.Orange;
            this.btnAtualizarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarProduto.Location = new System.Drawing.Point(251, 204);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(141, 23);
            this.btnAtualizarProduto.TabIndex = 15;
            this.btnAtualizarProduto.Text = "Atualizar Produto";
            this.btnAtualizarProduto.UseVisualStyleBackColor = false;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.Red;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Location = new System.Drawing.Point(276, 250);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(141, 23);
            this.btnExcluirProduto.TabIndex = 16;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.Cyan;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Location = new System.Drawing.Point(548, 36);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(126, 23);
            this.btnNovoPedido.TabIndex = 17;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.Gold;
            this.btnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(548, 65);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(126, 23);
            this.btnFinalizarPedido.TabIndex = 18;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Orange;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Location = new System.Drawing.Point(548, 94);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(126, 23);
            this.btnVenda.TabIndex = 19;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Crimson;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(548, 123);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 23);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(446, 420);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 29);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(537, 428);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 21);
            this.txtTotal.TabIndex = 22;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(15, 69);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(333, 23);
            this.cbxCliente.TabIndex = 23;
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(15, 118);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(333, 23);
            this.cbxProduto.TabIndex = 24;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::SisTDS06.Properties.Resources.vendas_21;
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnAtualizarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVendas";
            this.Text = "Pedido/Venda";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxProduto;
    }
}