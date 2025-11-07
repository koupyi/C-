namespace Aula_28_08
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
            TextBox textBox2;
            txt1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Entrar = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt1.Location = new Point(78, 59);
            txt1.Name = "txt1";
            txt1.Size = new Size(294, 47);
            txt1.TabIndex = 0;
            txt1.Text = "Acessar o sistema";
            txt1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 294);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 233);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 292);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // Entrar
            // 
            Entrar.BackColor = SystemColors.ActiveCaption;
            Entrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Entrar.Location = new Point(169, 416);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(108, 35);
            Entrar.TabIndex = 5;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 604);
            Controls.Add(Entrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button Entrar;
    }
}
