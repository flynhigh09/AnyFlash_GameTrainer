using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxShockwaveFlashObjects;

namespace AnyFlash_GameTrainer
{
    public partial class Game : Form
    {
        public static string Game_ = "";

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }
        private void startGame_Click(object sender, EventArgs e)
        {
        }

        private void Hack_button_Click(object sender, EventArgs e)
        {
            xShock_flashGame.SetVariable(VariableBox.Text, ValueBox.Text);

            this.Text = "Done";
        }

   
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xShock_flashGame.StopPlay();

            this.Text = "Paused";
        }

        private void exitStrip_Click(object sender, EventArgs e)
        {
            xShock_flashGame.Stop();

            this.Text = "Game Closed";
        }

        private void urlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game_Pick gmp = new Game_Pick();

            gmp.Show();

            this.Text = Game_;
        }


        private void loadSwf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = ("Swf (*.swf)|*.swf");
            DialogResult res = openfile.ShowDialog();
            if (res == DialogResult.OK)
            {
                 Game_= openfile.FileName;
                this.Text = Game_;
                xShock_flashGame.Movie = Game_;
            }
        }
    }
}

