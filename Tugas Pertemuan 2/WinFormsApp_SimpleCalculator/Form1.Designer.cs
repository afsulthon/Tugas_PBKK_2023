namespace WinFormsApp_SimpleCalculator
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
            title = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            buttonPlus = new Button();
            buttonMin = new Button();
            buttonTimes = new Button();
            buttonDiv = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Inter", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(63, 42);
            title.Name = "title";
            title.Size = new Size(332, 44);
            title.TabIndex = 0;
            title.Text = "Simple Calculator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 129);
            label1.Name = "label1";
            label1.Size = new Size(94, 29);
            label1.TabIndex = 1;
            label1.Text = "Value 1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Inter", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(199, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 46);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 199);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 3;
            label2.Text = "Value 2";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Inter", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(199, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 46);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(185, 265);
            label3.Name = "label3";
            label3.Size = new Size(87, 29);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Inter", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(63, 304);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(332, 46);
            textBox3.TabIndex = 6;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(50, 50, 50);
            buttonPlus.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlus.Location = new Point(111, 386);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 75);
            buttonPlus.TabIndex = 7;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.FromArgb(50, 50, 50);
            buttonMin.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMin.Location = new Point(192, 386);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(75, 75);
            buttonMin.TabIndex = 8;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = false;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonTimes
            // 
            buttonTimes.BackColor = Color.FromArgb(50, 50, 50);
            buttonTimes.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTimes.Location = new Point(111, 467);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(75, 75);
            buttonTimes.TabIndex = 9;
            buttonTimes.Text = "×";
            buttonTimes.UseVisualStyleBackColor = false;
            buttonTimes.Click += buttonTimes_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.FromArgb(50, 50, 50);
            buttonDiv.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDiv.Location = new Point(192, 467);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 75);
            buttonDiv.TabIndex = 10;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 214, 217);
            button1.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(50, 50, 50);
            button1.Location = new Point(273, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 156);
            button1.TabIndex = 11;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(458, 584);
            Controls.Add(button1);
            Controls.Add(buttonDiv);
            Controls.Add(buttonTimes);
            Controls.Add(buttonMin);
            Controls.Add(buttonPlus);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(title);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button buttonPlus;
        private Button buttonMin;
        private Button buttonTimes;
        private Button buttonDiv;
        private Button button1;
    }
}