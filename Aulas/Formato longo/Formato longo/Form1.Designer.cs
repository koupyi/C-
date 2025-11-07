namespace Formato_longo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateLabel1 = new DateTimePicker();
            dateLabel2 = new DateTimePicker();
            dateLabel3 = new DateTimePicker();
            dateLabel4 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 55);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Formato Longo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 137);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Formato Short";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 213);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Formato Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 298);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Formato  Custom";
            // 
            // dateLabel1
            // 
            dateLabel1.Location = new Point(258, 55);
            dateLabel1.Name = "dateLabel1";
            dateLabel1.Size = new Size(200, 23);
            dateLabel1.TabIndex = 4;
            dateLabel1.ValueChanged += dateLabel1_ValueChanged;
            // 
            // dateLabel2
            // 
            dateLabel2.Format = DateTimePickerFormat.Short;
            dateLabel2.Location = new Point(258, 131);
            dateLabel2.Name = "dateLabel2";
            dateLabel2.Size = new Size(200, 23);
            dateLabel2.TabIndex = 5;
            dateLabel2.ValueChanged += dateLabel2_ValueChanged;
            // 
            // dateLabel3
            // 
            dateLabel3.Format = DateTimePickerFormat.Time;
            dateLabel3.Location = new Point(258, 205);
            dateLabel3.Name = "dateLabel3";
            dateLabel3.Size = new Size(200, 23);
            dateLabel3.TabIndex = 6;
            // 
            // dateLabel4
            // 
            dateLabel4.Format = DateTimePickerFormat.Custom;
            dateLabel4.Location = new Point(258, 292);
            dateLabel4.Name = "dateLabel4";
            dateLabel4.Size = new Size(200, 23);
            dateLabel4.TabIndex = 7;
            dateLabel4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateLabel4);
            Controls.Add(dateLabel3);
            Controls.Add(dateLabel2);
            Controls.Add(dateLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateLabel1;
        private DateTimePicker dateLabel2;
        private DateTimePicker dateLabel3;
        private DateTimePicker dateLabel4;
    }
}
