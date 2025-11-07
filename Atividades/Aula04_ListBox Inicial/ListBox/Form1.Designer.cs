namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnLimparList = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPosLista = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblTextoSel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 18;
            this.lstLista.Location = new System.Drawing.Point(11, 68);
            this.lstLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLista.Name = "lstLista";
            this.lstLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLista.Size = new System.Drawing.Size(432, 184);
            this.lstLista.TabIndex = 0;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite uma palavra:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(154, 24);
            this.txtPalavra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(303, 25);
            this.txtPalavra.TabIndex = 2;
            this.txtPalavra.TextChanged += new System.EventHandler(this.txtPalavra_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(498, 24);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 48);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar no ListBox";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.Location = new System.Drawing.Point(498, 93);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(108, 48);
            this.btnEliminarItem.TabIndex = 4;
            this.btnEliminarItem.Text = "Eliminar Item Selecionado";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimparList
            // 
            this.btnLimparList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparList.Location = new System.Drawing.Point(498, 163);
            this.btnLimparList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimparList.Name = "btnLimparList";
            this.btnLimparList.Size = new System.Drawing.Size(108, 48);
            this.btnLimparList.TabIndex = 5;
            this.btnLimparList.Text = "Limpar ListBox";
            this.btnLimparList.UseVisualStyleBackColor = true;
            this.btnLimparList.Click += new System.EventHandler(this.btnLimparList_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(498, 233);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 48);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Posição na lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de itens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Texto Selecionado:";
            // 
            // lblPosLista
            // 
            this.lblPosLista.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosLista.Location = new System.Drawing.Point(132, 292);
            this.lblPosLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblPosLista.Name = "lblPosLista";
            this.lblPosLista.ReadOnly = true;
            this.lblPosLista.Size = new System.Drawing.Size(176, 25);
            this.lblPosLista.TabIndex = 10;
            this.lblPosLista.TextChanged += new System.EventHandler(this.lblPosLista_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(410, 292);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ReadOnly = true;
            this.lblTotal.Size = new System.Drawing.Size(48, 25);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblTextoSel
            // 
            this.lblTextoSel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSel.Location = new System.Drawing.Point(148, 333);
            this.lblTextoSel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblTextoSel.Name = "lblTextoSel";
            this.lblTextoSel.ReadOnly = true;
            this.lblTextoSel.Size = new System.Drawing.Size(309, 25);
            this.lblTextoSel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 374);
            this.Controls.Add(this.lblTextoSel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPosLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimparList);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Trabalhando com ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnLimparList;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblPosLista;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox lblTextoSel;
    }
}

