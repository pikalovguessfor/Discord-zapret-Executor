namespace PForm_path_fill
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
            TextBox InfoAboutProgramBOX;
            button_path = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            InfoAboutProgramBOX = new TextBox();
            SuspendLayout();
            // 
            // InfoAboutProgramBOX
            // 
            InfoAboutProgramBOX.Location = new Point(1, 422);
            InfoAboutProgramBOX.Name = "InfoAboutProgramBOX";
            InfoAboutProgramBOX.Size = new Size(231, 23);
            InfoAboutProgramBOX.TabIndex = 0;
            InfoAboutProgramBOX.Text = "Графическая реализация программы";
            // 
            // button_path
            // 
            button_path.Location = new Point(22, 225);
            button_path.Name = "button_path";
            button_path.Size = new Size(127, 23);
            button_path.TabIndex = 1;
            button_path.Text = "Заполнить пути";
            button_path.UseVisualStyleBackColor = true;
            button_path.Click += button_path_Click;
            // 
            // button1
            // 
            button1.Location = new Point(793, 189);
            button1.Name = "button1";
            button1.Size = new Size(159, 94);
            button1.TabIndex = 4;
            button1.Text = "Запустить скрипт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 225);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Готово";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 6;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 7;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.Location = new Point(233, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "Путь к дискорду:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            textBox4.Text = "Путь к запрету:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(994, 442);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_path);
            Controls.Add(InfoAboutProgramBOX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_path;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
