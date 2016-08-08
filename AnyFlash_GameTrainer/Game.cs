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
            Game_Pick gmp = new Game_Pick();

            gmp.Show();

            this.Text = Game_;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.StopPlay();
            this.Text = "Paused";
        }

        private void exitStrip_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Stop();
            this.Text = "Game Closed";
        }

        private void Hack_button_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.SetVariable(VariableBox.Text, ValueBox.Text);
            this.Text = "Done";
        }
    }
}

