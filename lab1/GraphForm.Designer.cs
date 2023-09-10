namespace lab1
{
    partial class GraphForm
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
            panel1 = new Panel();
            label5 = new Label();
            TextBoxH = new TextBox();
            label4 = new Label();
            DrawGraphButton = new Button();
            label3 = new Label();
            TextBoxXmax = new TextBox();
            label2 = new Label();
            TextBoxXmin = new TextBox();
            label1 = new Label();
            TextBoxA = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TextBoxH);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DrawGraphButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TextBoxXmax);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TextBoxXmin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBoxA);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 450);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 146);
            label5.Name = "label5";
            label5.Size = new Size(26, 24);
            label5.TabIndex = 9;
            label5.Text = "h:";
            // 
            // TextBoxH
            // 
            TextBoxH.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxH.Location = new Point(83, 143);
            TextBoxH.Name = "TextBoxH";
            TextBoxH.Size = new Size(176, 29);
            TextBoxH.TabIndex = 8;
            TextBoxH.Text = "0.001";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(247, 24);
            label4.TabIndex = 7;
            label4.Text = "f(x) = [sin(ax)+a*cos(x)^2]/45";
            // 
            // DrawGraphButton
            // 
            DrawGraphButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DrawGraphButton.Location = new Point(12, 178);
            DrawGraphButton.Name = "DrawGraphButton";
            DrawGraphButton.Size = new Size(247, 44);
            DrawGraphButton.TabIndex = 6;
            DrawGraphButton.Text = "Нарисовать";
            DrawGraphButton.UseVisualStyleBackColor = true;
            DrawGraphButton.Click += DrawGraphButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 5;
            label3.Text = "Xmax:";
            // 
            // TextBoxXmax
            // 
            TextBoxXmax.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxXmax.Location = new Point(83, 108);
            TextBoxXmax.Name = "TextBoxXmax";
            TextBoxXmax.Size = new Size(176, 29);
            TextBoxXmax.TabIndex = 4;
            TextBoxXmax.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 3;
            label2.Text = "Xmin:";
            // 
            // TextBoxXmin
            // 
            TextBoxXmin.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxXmin.Location = new Point(83, 73);
            TextBoxXmin.Name = "TextBoxXmin";
            TextBoxXmin.Size = new Size(176, 29);
            TextBoxXmin.TabIndex = 2;
            TextBoxXmin.Text = "-10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(25, 24);
            label1.TabIndex = 1;
            label1.Text = "a:";
            // 
            // TextBoxA
            // 
            TextBoxA.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxA.Location = new Point(83, 41);
            TextBoxA.Name = "TextBoxA";
            TextBoxA.Size = new Size(176, 29);
            TextBoxA.TabIndex = 0;
            TextBoxA.Text = "1";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(269, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 450);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GraphForm";
            Text = "GraphForm";
            ResizeEnd += GraphForm_ResizeEnd;
            Paint += GraphForm_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TextBoxA;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox TextBoxXmax;
        private Label label2;
        private TextBox TextBoxXmin;
        private Label label4;
        private Button DrawGraphButton;
        private Label label5;
        private TextBox TextBoxH;
    }
}