namespace Gui_implementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Zapret_Path_Box.Visible = false;
            Zapret_Path_Label.Visible = false;

            Discord_Path_Box.Visible = false;
            Discord_Path_Label.Visible = false;

            Fill_Ready_Button.Visible = false;
        }

        private void Fill_paths_button_Click(object sender, EventArgs e)
        {

            Zapret_Path_Box.Visible = true;
            Zapret_Path_Label.Visible = true;

            Discord_Path_Box.Visible=true;
            Discord_Path_Label.Visible=true;

            Fill_Ready_Button.Visible=true;

        }

        private void Fill_Ready_Button_Click(object sender, EventArgs e)
        {

        }

        private void Auto_Fill_Path_Button_Click(object sender, EventArgs e)
        {

        }

        private void Execute_Script_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
