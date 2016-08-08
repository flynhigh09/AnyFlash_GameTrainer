namespace AnyFlash_GameTrainer
{
    partial class Game_Pick
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadGame = new System.Windows.Forms.Button();
            this.GameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(585, 31);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(75, 23);
            this.LoadGame.TabIndex = 0;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // GameTextBox
            // 
            this.GameTextBox.Location = new System.Drawing.Point(84, 31);
            this.GameTextBox.Name = "GameTextBox";
            this.GameTextBox.Size = new System.Drawing.Size(486, 20);
            this.GameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game URL :";
            // 
            // Game_Pick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 65);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameTextBox);
            this.Controls.Add(this.LoadGame);
            this.Name = "Game_Pick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick a Flash Game";
            this.Load += new System.EventHandler(this.Game_Pick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.TextBox GameTextBox;
        private System.Windows.Forms.Label label1;
    }
}

