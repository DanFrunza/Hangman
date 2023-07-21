namespace Spanzuratoarea
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
            p = new PictureBox();
            litera = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            SuspendLayout();
            // 
            // p
            // 
            p.Location = new Point(33, 28);
            p.Name = "p";
            p.Size = new Size(638, 495);
            p.TabIndex = 0;
            p.TabStop = false;
            p.Paint += p_Paint;
            // 
            // litera
            // 
            litera.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            litera.Location = new Point(312, 581);
            litera.MaxLength = 1;
            litera.Multiline = true;
            litera.Name = "litera";
            litera.Size = new Size(125, 53);
            litera.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 584);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 2;
            label1.Text = "Ghiceste litera:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(511, 596);
            button1.Name = "button1";
            button1.Size = new Size(149, 48);
            button1.TabIndex = 3;
            button1.Text = "Verifica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 679);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(litera);
            Controls.Add(p);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox p;
        private TextBox litera;
        private Label label1;
        private Button button1;
    }
}