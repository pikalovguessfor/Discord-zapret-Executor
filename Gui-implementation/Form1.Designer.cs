namespace Gui_implementation
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
            Fill_paths_button = new Button();
            Discord_Path_Box = new TextBox();
            Fill_Ready_Button = new Button();
            Execute_Script_Button = new Button();
            Auto_Fill_Path_Button = new Button();
            Zapret_Path_Box = new TextBox();
            Zapret_Path_Label = new Label();
            Discord_Path_Label = new Label();
            InfoGraphicImplementation = new TextBox();
            SuspendLayout();
            // 
            // Fill_paths_button
            // 
            Fill_paths_button.Location = new Point(12, 258);
            Fill_paths_button.Name = "Fill_paths_button";
            Fill_paths_button.Size = new Size(128, 43);
            Fill_paths_button.TabIndex = 0;
            Fill_paths_button.Text = "Заполнить пути";
            Fill_paths_button.UseVisualStyleBackColor = true;
            Fill_paths_button.Click += Fill_paths_button_Click;
            // 
            // Discord_Path_Box
            // 
            Discord_Path_Box.Location = new Point(146, 299);
            Discord_Path_Box.Name = "Discord_Path_Box";
            Discord_Path_Box.Size = new Size(275, 23);
            Discord_Path_Box.TabIndex = 2;
            // 
            // Fill_Ready_Button
            // 
            Fill_Ready_Button.Location = new Point(427, 258);
            Fill_Ready_Button.Name = "Fill_Ready_Button";
            Fill_Ready_Button.Size = new Size(122, 43);
            Fill_Ready_Button.TabIndex = 3;
            Fill_Ready_Button.Text = "Готово";
            Fill_Ready_Button.UseVisualStyleBackColor = true;
            Fill_Ready_Button.Click += Fill_Ready_Button_Click;
            // 
            // Execute_Script_Button
            // 
            Execute_Script_Button.Location = new Point(1015, 258);
            Execute_Script_Button.Name = "Execute_Script_Button";
            Execute_Script_Button.Size = new Size(122, 43);
            Execute_Script_Button.TabIndex = 4;
            Execute_Script_Button.Text = "Запустить скрипт";
            Execute_Script_Button.UseVisualStyleBackColor = true;
            Execute_Script_Button.Click += Execute_Script_Button_Click;
            // 
            // Auto_Fill_Path_Button
            // 
            Auto_Fill_Path_Button.Location = new Point(602, 573);
            Auto_Fill_Path_Button.Name = "Auto_Fill_Path_Button";
            Auto_Fill_Path_Button.Size = new Size(561, 43);
            Auto_Fill_Path_Button.TabIndex = 5;
            Auto_Fill_Path_Button.Text = "Автоматически найти пути к файлам и заполнить их";
            Auto_Fill_Path_Button.UseVisualStyleBackColor = true;
            Auto_Fill_Path_Button.Click += Auto_Fill_Path_Button_Click;
            // 
            // Zapret_Path_Box
            // 
            Zapret_Path_Box.Location = new Point(146, 239);
            Zapret_Path_Box.Name = "Zapret_Path_Box";
            Zapret_Path_Box.Size = new Size(275, 23);
            Zapret_Path_Box.TabIndex = 1;
            // 
            // Zapret_Path_Label
            // 
            Zapret_Path_Label.AutoSize = true;
            Zapret_Path_Label.Location = new Point(146, 221);
            Zapret_Path_Label.Name = "Zapret_Path_Label";
            Zapret_Path_Label.Size = new Size(87, 15);
            Zapret_Path_Label.TabIndex = 6;
            Zapret_Path_Label.Text = "Путь к запрету";
            // 
            // Discord_Path_Label
            // 
            Discord_Path_Label.AutoSize = true;
            Discord_Path_Label.Location = new Point(146, 325);
            Discord_Path_Label.Name = "Discord_Path_Label";
            Discord_Path_Label.Size = new Size(96, 15);
            Discord_Path_Label.TabIndex = 7;
            Discord_Path_Label.Text = "Путь к дискорду";
            // 
            // InfoGraphicImplementation
            // 
            InfoGraphicImplementation.Location = new Point(2, 604);
            InfoGraphicImplementation.Name = "InfoGraphicImplementation";
            InfoGraphicImplementation.Size = new Size(275, 23);
            InfoGraphicImplementation.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1199, 628);
            Controls.Add(InfoGraphicImplementation);
            Controls.Add(Discord_Path_Label);
            Controls.Add(Zapret_Path_Label);
            Controls.Add(Auto_Fill_Path_Button);
            Controls.Add(Execute_Script_Button);
            Controls.Add(Fill_Ready_Button);
            Controls.Add(Discord_Path_Box);
            Controls.Add(Zapret_Path_Box);
            Controls.Add(Fill_paths_button);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Discord+Zapret executor Gui";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Fill_paths_button;
        private TextBox Discord_Path_Box;
        private Button Fill_Ready_Button;
        private Button Execute_Script_Button;
        private Button Auto_Fill_Path_Button;
        private TextBox Zapret_Path_Box;
        private Label Zapret_Path_Label;
        private Label Discord_Path_Label;
        private TextBox InfoGraphicImplementation;
    }
}
