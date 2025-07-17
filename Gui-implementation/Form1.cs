using System.ComponentModel;
using System.Security.Cryptography;

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

            InfoGraphicImplementation.Text = "Графическая реализация программы";
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

            sc_FileWork zapretFiller = new sc_FileWork("_resourses/zapret_path.txt", this.Zapret_Path_Box.Text);        //Write paths to execute inside zapret_path.txt Algorithm
            sc_FileWork discordFiller = new sc_FileWork("_resourses/discord_path.txt", this.Discord_Path_Box.Text);     //Write paths to execute inside discord_path.txt Algorithm
            
        }

        private void Auto_Fill_Path_Button_Click(object sender, EventArgs e)
        {

        }

        private void Execute_Script_Button_Click(object sender, EventArgs e)
        {

            sc_ProcessWork sc_Process = new sc_ProcessWork();
            sc_Process.ProcessExecute("Discord+zapret Exec.exe");

            this.Close();
        }
    }
}
