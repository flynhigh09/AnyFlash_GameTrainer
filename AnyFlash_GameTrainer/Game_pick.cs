using System;
using System.Windows.Forms;

namespace AnyFlash_GameTrainer
{
    public partial class Game_Pick : Form
    {
        Game game_form;
        string url = "";

        public Game_Pick()
        {
            InitializeComponent();          
        }

        private void Game_Pick_Load(object sender, EventArgs e)
        {
            game_form = new Game();
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            url = game_form.xShock_flashGame.Movie = GameTextBox.Text;

            Game.Game_ = url;

            this.Close();
        }
    }
}
