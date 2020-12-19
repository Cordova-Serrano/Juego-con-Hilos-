namespace Simulation_Threads
{
    partial class WinScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinScreen));
            this.exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitGame
            // 
            this.exitGame.Font = new System.Drawing.Font("Dark College", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(257, 212);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(87, 34);
            this.exitGame.TabIndex = 0;
            this.exitGame.Text = "EXIT";
            this.exitGame.UseVisualStyleBackColor = true;
            this.exitGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitGame_MouseClick);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.exitGame);
            this.Name = "WinScreen";
            this.Text = "WinScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitGame;
    }
}