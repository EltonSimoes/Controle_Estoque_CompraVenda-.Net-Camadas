namespace UI_UserInterfacePresentation
{
    partial class FrmPedidoVendaCadastrar
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
            this.lblEmitente = new System.Windows.Forms.Label();
            this.txtEmitente = new System.Windows.Forms.TextBox();
            this.btnPesquisarEmitente = new System.Windows.Forms.Button();
            this.btnPesquisarDestinatario = new System.Windows.Forms.Button();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtDataOperacao = new System.Windows.Forms.TextBox();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.gbxItens = new System.Windows.Forms.GroupBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtItens = new System.Windows.Forms.TextBox();
            this.lblItens = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtProdutoCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.txtProdutoDescricao = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmitente
            // 
            this.lblEmitente.AutoSize = true;
            this.lblEmitente.Location = new System.Drawing.Point(9, 0);
            this.lblEmitente.Name = "lblEmitente";
            this.lblEmitente.Size = new System.Drawing.Size(63, 17);
            this.lblEmitente.TabIndex = 0;
            this.lblEmitente.Text = "Emitente";
            // 
            // txtEmitente
            // 
            this.txtEmitente.Location = new System.Drawing.Point(9, 17);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.Size = new System.Drawing.Size(455, 22);
            this.txtEmitente.TabIndex = 1;
            // 
            // btnPesquisarEmitente
            // 
            this.btnPesquisarEmitente.Location = new System.Drawing.Point(471, 17);
            this.btnPesquisarEmitente.Name = "btnPesquisarEmitente";
            this.btnPesquisarEmitente.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisarEmitente.TabIndex = 2;
            this.btnPesquisarEmitente.Text = ". . .";
            this.btnPesquisarEmitente.UseVisualStyleBackColor = true;
            this.btnPesquisarEmitente.Click += new System.EventHandler(this.btnPesquisarEmitente_Click);
            // 
            // btnPesquisarDestinatario
            // 
            this.btnPesquisarDestinatario.Location = new System.Drawing.Point(471, 67);
            this.btnPesquisarDestinatario.Name = "btnPesquisarDestinatario";
            this.btnPesquisarDestinatario.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisarDestinatario.TabIndex = 5;
            this.btnPesquisarDestinatario.Text = ". . .";
            this.btnPesquisarDestinatario.UseVisualStyleBackColor = true;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(9, 67);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(455, 22);
            this.txtDestinatario.TabIndex = 4;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(9, 50);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(84, 17);
            this.lblDestinatario.TabIndex = 3;
            this.lblDestinatario.Text = "Destinatário";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(545, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(545, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(101, 22);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.TabStop = false;
            // 
            // txtOperacao
            // 
            this.txtOperacao.Location = new System.Drawing.Point(545, 68);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.ReadOnly = true;
            this.txtOperacao.Size = new System.Drawing.Size(101, 22);
            this.txtOperacao.TabIndex = 15;
            this.txtOperacao.TabStop = false;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(545, 50);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(71, 17);
            this.lblOperacao.TabIndex = 14;
            this.lblOperacao.Text = "Operação";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(670, 68);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(101, 22);
            this.txtSituacao.TabIndex = 19;
            this.txtSituacao.TabStop = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(670, 50);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(63, 17);
            this.lblSituacao.TabIndex = 18;
            this.lblSituacao.Text = "Situação";
            // 
            // txtDataOperacao
            // 
            this.txtDataOperacao.Location = new System.Drawing.Point(670, 17);
            this.txtDataOperacao.Name = "txtDataOperacao";
            this.txtDataOperacao.ReadOnly = true;
            this.txtDataOperacao.Size = new System.Drawing.Size(101, 22);
            this.txtDataOperacao.TabIndex = 17;
            this.txtDataOperacao.TabStop = false;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(670, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(73, 17);
            this.lblDataHora.TabIndex = 16;
            this.lblDataHora.Text = "Data/Hora";
            // 
            // gbxItens
            // 
            this.gbxItens.Controls.Add(this.lblValorUnitario);
            this.gbxItens.Controls.Add(this.txtValorUnitario);
            this.gbxItens.Controls.Add(this.lblDesconto);
            this.gbxItens.Controls.Add(this.txtDesconto);
            this.gbxItens.Controls.Add(this.btnExcluir);
            this.gbxItens.Controls.Add(this.btnAlterar);
            this.gbxItens.Controls.Add(this.lblEstoque);
            this.gbxItens.Controls.Add(this.lblValor);
            this.gbxItens.Controls.Add(this.txtEstoque);
            this.gbxItens.Controls.Add(this.txtValor);
            this.gbxItens.Controls.Add(this.txtItens);
            this.gbxItens.Controls.Add(this.lblItens);
            this.gbxItens.Controls.Add(this.btnInserir);
            this.gbxItens.Controls.Add(this.txtQuantidade);
            this.gbxItens.Controls.Add(this.lblQuantidade);
            this.gbxItens.Controls.Add(this.txtProdutoCodigo);
            this.gbxItens.Controls.Add(this.btnPesquisarProduto);
            this.gbxItens.Controls.Add(this.dgvPrincipal);
            this.gbxItens.Controls.Add(this.txtProdutoDescricao);
            this.gbxItens.Controls.Add(this.lblProduto);
            this.gbxItens.Location = new System.Drawing.Point(9, 96);
            this.gbxItens.Name = "gbxItens";
            this.gbxItens.Size = new System.Drawing.Size(761, 263);
            this.gbxItens.TabIndex = 6;
            this.gbxItens.TabStop = false;
            this.gbxItens.Text = "Itens";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(472, 18);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(94, 17);
            this.lblValorUnitario.TabIndex = 38;
            this.lblValorUnitario.Text = "Valor Unitário";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(472, 38);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(89, 22);
            this.txtValorUnitario.TabIndex = 37;
            this.txtValorUnitario.TabStop = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(567, 18);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(84, 17);
            this.lblDesconto.TabIndex = 36;
            this.lblDesconto.Text = "% Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(567, 38);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(89, 22);
            this.txtDesconto.TabIndex = 35;
            this.txtDesconto.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(686, 234);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(615, 234);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(662, 18);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(60, 17);
            this.lblEstoque.TabIndex = 32;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(143, 237);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 17);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(662, 38);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(89, 22);
            this.txtEstoque.TabIndex = 30;
            this.txtEstoque.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(190, 234);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(84, 22);
            this.txtValor.TabIndex = 29;
            this.txtValor.TabStop = false;
            // 
            // txtItens
            // 
            this.txtItens.Location = new System.Drawing.Point(50, 234);
            this.txtItens.Name = "txtItens";
            this.txtItens.ReadOnly = true;
            this.txtItens.Size = new System.Drawing.Size(87, 22);
            this.txtItens.TabIndex = 28;
            this.txtItens.TabStop = false;
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(7, 237);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(42, 17);
            this.lblItens.TabIndex = 27;
            this.lblItens.Text = "Itens:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(410, 38);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(56, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(322, 38);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(82, 22);
            this.txtQuantidade.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(322, 18);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtProdutoCodigo
            // 
            this.txtProdutoCodigo.Location = new System.Drawing.Point(6, 38);
            this.txtProdutoCodigo.Name = "txtProdutoCodigo";
            this.txtProdutoCodigo.ReadOnly = true;
            this.txtProdutoCodigo.Size = new System.Drawing.Size(56, 22);
            this.txtProdutoCodigo.TabIndex = 1;
            this.txtProdutoCodigo.TabStop = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(276, 37);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisarProduto.TabIndex = 3;
            this.btnPesquisarProduto.Text = ". . .";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(7, 68);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RowTemplate.Height = 24;
            this.dgvPrincipal.Size = new System.Drawing.Size(744, 160);
            this.dgvPrincipal.TabIndex = 7;
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Location = new System.Drawing.Point(68, 37);
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(202, 22);
            this.txtProdutoDescricao.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 18);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(58, 17);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(699, 375);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(611, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(534, 375);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(71, 23);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoVendaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxItens);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.txtDataOperacao);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnPesquisarDestinatario);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.btnPesquisarEmitente);
            this.Controls.Add(this.txtEmitente);
            this.Controls.Add(this.lblEmitente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidoVendaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Venda";
            this.gbxItens.ResumeLayout(false);
            this.gbxItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmitente;
        private System.Windows.Forms.TextBox txtEmitente;
        private System.Windows.Forms.Button btnPesquisarEmitente;
        private System.Windows.Forms.Button btnPesquisarDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtDataOperacao;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.GroupBox gbxItens;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtProdutoCodigo;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.TextBox txtProdutoDescricao;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtItens;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}