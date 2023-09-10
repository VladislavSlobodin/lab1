namespace lab1
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
            panel1 = new Panel();
            ShowGraphButton = new Button();
            ShowChangingRhombusButton = new Button();
            ShowSketchButton = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            FormPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ShowGraphButton);
            panel1.Controls.Add(ShowChangingRhombusButton);
            panel1.Controls.Add(ShowSketchButton);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // ShowGraphButton
            // 
            ShowGraphButton.Dock = DockStyle.Top;
            ShowGraphButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowGraphButton.Location = new Point(0, 240);
            ShowGraphButton.Name = "ShowGraphButton";
            ShowGraphButton.Size = new Size(198, 70);
            ShowGraphButton.TabIndex = 4;
            ShowGraphButton.Text = "График";
            ShowGraphButton.UseVisualStyleBackColor = true;
            ShowGraphButton.Click += ShowGraphButton_Click;
            // 
            // ShowChangingRhombusButton
            // 
            ShowChangingRhombusButton.Dock = DockStyle.Top;
            ShowChangingRhombusButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowChangingRhombusButton.Location = new Point(0, 170);
            ShowChangingRhombusButton.Name = "ShowChangingRhombusButton";
            ShowChangingRhombusButton.Size = new Size(198, 70);
            ShowChangingRhombusButton.TabIndex = 3;
            ShowChangingRhombusButton.Text = "Изменяющийся ромб";
            ShowChangingRhombusButton.UseVisualStyleBackColor = true;
            ShowChangingRhombusButton.Click += ShowChangingRhombusButton_Click;
            // 
            // ShowSketchButton
            // 
            ShowSketchButton.Dock = DockStyle.Top;
            ShowSketchButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ShowSketchButton.Location = new Point(0, 100);
            ShowSketchButton.Name = "ShowSketchButton";
            ShowSketchButton.Size = new Size(198, 70);
            ShowSketchButton.TabIndex = 2;
            ShowSketchButton.Text = "Эскиз";
            ShowSketchButton.UseVisualStyleBackColor = true;
            ShowSketchButton.Click += ShowSketchButton_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 100);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 48);
            label1.TabIndex = 0;
            label1.Text = "Слободин В.С.\r\nИСТ-41";
            label1.DoubleClick += label1_DoubleClick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 100);
            panel2.TabIndex = 1;
            // 
            // FormPanel
            // 
            FormPanel.BorderStyle = BorderStyle.FixedSingle;
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(200, 100);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(600, 350);
            FormPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            ResizeEnd += Form1_ResizeEnd;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ShowGraphButton;
        private Button ShowChangingRhombusButton;
        private Button ShowSketchButton;
        private Panel panel3;
        private Panel panel2;
        private Panel FormPanel;
        private Label label1;
    }
}