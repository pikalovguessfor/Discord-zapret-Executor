using System.Diagnostics;

namespace PForm_path_fill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_path_Click(object sender, EventArgs e)
        {

            textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            const string PATHToDiscordTXT = "_resourses/discord_path.txt";
            const string PATHToZapretTXT = "_resourses/zapret_path.txt";

            FileWrite.WriteInfoInTXT_Script(PATHToDiscordTXT, textBox1.Text);
            FileWrite.WriteInfoInTXT_Script(PATHToZapretTXT, textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string ScriptPath = "Discord+zapret exec";


            Process.Start(ScriptPath);

        }
    }
}
