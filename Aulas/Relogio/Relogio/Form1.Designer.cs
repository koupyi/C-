namespace Relogio
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
            components = new System.ComponentModel.Container();
            btnSair = new Button();
            txtTempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(374, 315);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Text = "button1";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtTempo
            // 
            txtTempo.Anchor = AnchorStyles.Left;
            txtTempo.AutoSize = true;
            txtTempo.BorderStyle = BorderStyle.Fixed3D;
            txtTempo.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTempo.Location = new Point(267, 80);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(309, 130);
            txtTempo.TabIndex = 1;
            txtTempo.Text = "label1";
            txtTempo.TextAlign = ContentAlignment.MiddleCenter;
            txtTempo.Click += txtTempo_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTempo);
            Controls.Add(btnSair);
            Name = "Form1";
            Text = ",";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Label txtTempo;
        private System.Windows.Forms.Timer timer1;
    }
}
