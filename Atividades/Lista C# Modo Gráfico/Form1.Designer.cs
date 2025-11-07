namespace Lista_C__Modo_Gráfico
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
            label1 = new Label();
            txtParimpar = new TextBox();
            txtResultado1 = new Label();
            btnVerificar = new Button();
            label3 = new Label();
            txtNumero1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtNumero2 = new TextBox();
            label6 = new Label();
            btnMaior = new Button();
            txtMaior = new Label();
            label8 = new Label();
            label9 = new Label();
            txtOpção = new TextBox();
            label10 = new Label();
            btn3 = new Button();
            txt1 = new TextBox();
            label7 = new Label();
            label11 = new Label();
            txt2 = new TextBox();
            TxtResultado2 = new Label();
            label12 = new Label();
            txtNome = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtSexo = new TextBox();
            label15 = new Label();
            txtIdade = new TextBox();
            btnEnviar = new Button();
            txtResultado3 = new Label();
            label16 = new Label();
            txtIdade2 = new TextBox();
            label17 = new Label();
            btnClasse = new Button();
            txtClasse = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 76);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "Insira um numero";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // txtParimpar
            // 
            txtParimpar.Location = new Point(46, 100);
            txtParimpar.Name = "txtParimpar";
            txtParimpar.Size = new Size(177, 23);
            txtParimpar.TabIndex = 1;
            txtParimpar.TextChanged += textBox1_TextChanged;
            // 
            // txtResultado1
            // 
            txtResultado1.AutoSize = true;
            txtResultado1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado1.Location = new Point(46, 157);
            txtResultado1.Name = "txtResultado1";
            txtResultado1.Size = new Size(129, 30);
            txtResultado1.TabIndex = 2;
            txtResultado1.Text = "O numero é:";
            txtResultado1.Click += label2_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(46, 232);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(177, 33);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar se o numero é impar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 229);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 4;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(275, 100);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(177, 23);
            txtNumero1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 9);
            label4.Name = "label4";
            label4.Size = new Size(177, 30);
            label4.TabIndex = 7;
            label4.Text = "Primeiro exercício";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(275, 9);
            label5.Name = "label5";
            label5.Size = new Size(182, 30);
            label5.TabIndex = 8;
            label5.Text = "Segundo exercício";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 76);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 9;
            label2.Text = "Insira o primeiro numero";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click_1;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(275, 166);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(177, 23);
            txtNumero2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 142);
            label6.Name = "label6";
            label6.Size = new Size(184, 21);
            label6.TabIndex = 11;
            label6.Text = "Insira o segundo numero";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(275, 195);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(177, 33);
            btnMaior.TabIndex = 12;
            btnMaior.Text = "Verificar o numero maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtMaior
            // 
            txtMaior.AutoSize = true;
            txtMaior.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaior.Location = new Point(275, 244);
            txtMaior.Name = "txtMaior";
            txtMaior.Size = new Size(188, 30);
            txtMaior.TabIndex = 13;
            txtMaior.Text = "O maior numero é:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(502, 54);
            label8.Name = "label8";
            label8.Size = new Size(160, 60);
            label8.TabIndex = 14;
            label8.Text = "Menu de opções:\r\n\r\n1 – Somar dois números.\r\n2 – Multiplicar dois números.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(502, 9);
            label9.Name = "label9";
            label9.Size = new Size(172, 30);
            label9.TabIndex = 15;
            label9.Text = "Terceiro exercício";
            // 
            // txtOpção
            // 
            txtOpção.Location = new Point(502, 166);
            txtOpção.Name = "txtOpção";
            txtOpção.Size = new Size(177, 23);
            txtOpção.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(502, 142);
            label10.Name = "label10";
            label10.Size = new Size(177, 21);
            label10.TabIndex = 17;
            label10.Text = "Digite a opção desejada:";
            // 
            // btn3
            // 
            btn3.Location = new Point(502, 346);
            btn3.Name = "btn3";
            btn3.Size = new Size(177, 33);
            btn3.TabIndex = 18;
            btn3.Text = "Realizar equação";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(502, 238);
            txt1.Name = "txt1";
            txt1.Size = new Size(177, 23);
            txt1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(502, 214);
            label7.Name = "label7";
            label7.Size = new Size(184, 21);
            label7.TabIndex = 20;
            label7.Text = "Insira o primeiro numero";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(502, 282);
            label11.Name = "label11";
            label11.Size = new Size(184, 21);
            label11.TabIndex = 21;
            label11.Text = "Insira o segundo numero";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt2
            // 
            txt2.Location = new Point(502, 306);
            txt2.Name = "txt2";
            txt2.Size = new Size(177, 23);
            txt2.TabIndex = 22;
            // 
            // TxtResultado2
            // 
            TxtResultado2.AutoSize = true;
            TxtResultado2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtResultado2.Location = new Point(502, 382);
            TxtResultado2.Name = "TxtResultado2";
            TxtResultado2.Size = new Size(129, 30);
            TxtResultado2.TabIndex = 23;
            TxtResultado2.Text = "O numero é:";
            TxtResultado2.Click += TxtResultado2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(751, 9);
            label12.Name = "label12";
            label12.Size = new Size(165, 30);
            label12.TabIndex = 24;
            label12.Text = "Quarto exercício";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(751, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(751, 67);
            label13.Name = "label13";
            label13.Size = new Size(111, 21);
            label13.TabIndex = 27;
            label13.Text = "Digite o nome:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(751, 142);
            label14.Name = "label14";
            label14.Size = new Size(102, 21);
            label14.TabIndex = 29;
            label14.Text = "Digite o sexo:";
            label14.Click += label14_Click;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(751, 164);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(177, 23);
            txtSexo.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(751, 214);
            label15.Name = "label15";
            label15.Size = new Size(108, 21);
            label15.TabIndex = 31;
            label15.Text = "Digite a idade:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(751, 238);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(177, 23);
            txtIdade.TabIndex = 30;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(751, 282);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(177, 33);
            btnEnviar.TabIndex = 32;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtResultado3
            // 
            txtResultado3.AutoSize = true;
            txtResultado3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado3.Location = new Point(751, 346);
            txtResultado3.Name = "txtResultado3";
            txtResultado3.Size = new Size(93, 30);
            txtResultado3.TabIndex = 33;
            txtResultado3.Text = "Você foi:";
            txtResultado3.Click += txtResultado3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(995, 9);
            label16.Name = "label16";
            label16.Size = new Size(164, 30);
            label16.TabIndex = 34;
            label16.Text = "Quinto exercício";
            // 
            // txtIdade2
            // 
            txtIdade2.Location = new Point(995, 91);
            txtIdade2.Name = "txtIdade2";
            txtIdade2.Size = new Size(177, 23);
            txtIdade2.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(995, 67);
            label17.Name = "label17";
            label17.Size = new Size(108, 21);
            label17.TabIndex = 36;
            label17.Text = "Digite a idade:";
            // 
            // btnClasse
            // 
            btnClasse.Location = new Point(995, 154);
            btnClasse.Name = "btnClasse";
            btnClasse.Size = new Size(177, 33);
            btnClasse.TabIndex = 37;
            btnClasse.Text = "Descobrir classe eleitoral";
            btnClasse.UseVisualStyleBackColor = true;
            btnClasse.Click += btnClasse_Click;
            // 
            // txtClasse
            // 
            txtClasse.AutoSize = true;
            txtClasse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClasse.Location = new Point(995, 214);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(191, 25);
            txtClasse.TabIndex = 38;
            txtClasse.Text = "Sua classe eleitoral é:";
            txtClasse.Click += txtClasse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 450);
            Controls.Add(txtClasse);
            Controls.Add(btnClasse);
            Controls.Add(label17);
            Controls.Add(txtIdade2);
            Controls.Add(label16);
            Controls.Add(txtResultado3);
            Controls.Add(btnEnviar);
            Controls.Add(label15);
            Controls.Add(txtIdade);
            Controls.Add(label14);
            Controls.Add(txtSexo);
            Controls.Add(label13);
            Controls.Add(txtNome);
            Controls.Add(label12);
            Controls.Add(TxtResultado2);
            Controls.Add(txt2);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(txt1);
            Controls.Add(btn3);
            Controls.Add(label10);
            Controls.Add(txtOpção);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtMaior);
            Controls.Add(btnMaior);
            Controls.Add(label6);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(btnVerificar);
            Controls.Add(txtResultado1);
            Controls.Add(txtParimpar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtParimpar;
        private Label txtResultado1;
        private Button btnVerificar;
        private Label label3;
        private TextBox txtNumero1;
        private Label label4;
        private Label label5;
        private Label label2;
        private TextBox txtNumero2;
        private Label label6;
        private Button btnMaior;
        private Label txtMaior;
        private Label label8;
        private Label label9;
        private TextBox txtOpção;
        private Label label10;
        private Button btn3;
        private TextBox txt1;
        private Label label7;
        private Label label11;
        private TextBox txt2;
        private Label TxtResultado2;
        private Label label12;
        private TextBox txtNome;
        private Label label13;
        private Label label14;
        private TextBox txtSexo;
        private Label label15;
        private TextBox txtIdade;
        private Button btnEnviar;
        private Label txtResultado3;
        private Label label16;
        private TextBox txtIdade2;
        private Label label17;
        private Button btnClasse;
        private Label txtClasse;
    }
}
