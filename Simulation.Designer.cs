namespace Simulation_Threads
{
    partial class Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.tank = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.speedHUD = new System.Windows.Forms.PictureBox();
            this.statusHUD = new System.Windows.Forms.PictureBox();
            this.ammoHUD = new System.Windows.Forms.PictureBox();
            this.bulletEnemy = new System.Windows.Forms.PictureBox();
            this.youLose = new System.Windows.Forms.PictureBox();
            this.retryBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedHUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusHUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoHUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youLose)).BeginInit();
            this.SuspendLayout();
            // 
            // tank
            // 
            this.tank.BackColor = System.Drawing.Color.Transparent;
            this.tank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tank.BackgroundImage")));
            this.tank.Location = new System.Drawing.Point(532, 422);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(104, 145);
            this.tank.TabIndex = 0;
            this.tank.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.BackColor = System.Drawing.Color.Transparent;
            this.bullet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bullet1.BackgroundImage")));
            this.bullet1.Location = new System.Drawing.Point(1212, 381);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(40, 146);
            this.bullet1.TabIndex = 1;
            this.bullet1.TabStop = false;
            this.bullet1.Visible = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy.BackgroundImage")));
            this.enemy.Location = new System.Drawing.Point(1150, 3);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(102, 191);
            this.enemy.TabIndex = 2;
            this.enemy.TabStop = false;
            // 
            // speedHUD
            // 
            this.speedHUD.BackColor = System.Drawing.Color.Transparent;
            this.speedHUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speedHUD.BackgroundImage")));
            this.speedHUD.Location = new System.Drawing.Point(90, 582);
            this.speedHUD.Name = "speedHUD";
            this.speedHUD.Size = new System.Drawing.Size(156, 99);
            this.speedHUD.TabIndex = 3;
            this.speedHUD.TabStop = false;
            // 
            // statusHUD
            // 
            this.statusHUD.BackColor = System.Drawing.Color.Transparent;
            this.statusHUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusHUD.BackgroundImage")));
            this.statusHUD.Location = new System.Drawing.Point(392, 628);
            this.statusHUD.Name = "statusHUD";
            this.statusHUD.Size = new System.Drawing.Size(480, 18);
            this.statusHUD.TabIndex = 4;
            this.statusHUD.TabStop = false;
            // 
            // ammoHUD
            // 
            this.ammoHUD.BackColor = System.Drawing.Color.Transparent;
            this.ammoHUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ammoHUD.BackgroundImage")));
            this.ammoHUD.Location = new System.Drawing.Point(1004, 533);
            this.ammoHUD.Name = "ammoHUD";
            this.ammoHUD.Size = new System.Drawing.Size(248, 148);
            this.ammoHUD.TabIndex = 5;
            this.ammoHUD.TabStop = false;
            this.ammoHUD.UseWaitCursor = true;
            // 
            // bulletEnemy
            // 
            this.bulletEnemy.BackColor = System.Drawing.Color.Transparent;
            this.bulletEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulletEnemy.BackgroundImage")));
            this.bulletEnemy.Location = new System.Drawing.Point(567, 3);
            this.bulletEnemy.Name = "bulletEnemy";
            this.bulletEnemy.Size = new System.Drawing.Size(40, 146);
            this.bulletEnemy.TabIndex = 6;
            this.bulletEnemy.TabStop = false;
            // 
            // youLose
            // 
            this.youLose.BackColor = System.Drawing.Color.Transparent;
            this.youLose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("youLose.BackgroundImage")));
            this.youLose.Location = new System.Drawing.Point(461, 297);
            this.youLose.Name = "youLose";
            this.youLose.Size = new System.Drawing.Size(370, 87);
            this.youLose.TabIndex = 7;
            this.youLose.TabStop = false;
            this.youLose.Visible = false;
            // 
            // retryBtn
            // 
            this.retryBtn.Location = new System.Drawing.Point(548, 390);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(75, 23);
            this.retryBtn.TabIndex = 8;
            this.retryBtn.Text = "R E T R Y";
            this.retryBtn.UseVisualStyleBackColor = true;
            this.retryBtn.Visible = false;
            this.retryBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.retryBtn_MouseClick);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(685, 390);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "E X I T ";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Visible = false;
            this.exitBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseClick);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.retryBtn);
            this.Controls.Add(this.youLose);
            this.Controls.Add(this.bulletEnemy);
            this.Controls.Add(this.ammoHUD);
            this.Controls.Add(this.statusHUD);
            this.Controls.Add(this.speedHUD);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.tank);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Simulation_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Simulation_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedHUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusHUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoHUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tank;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox speedHUD;
        private System.Windows.Forms.PictureBox statusHUD;
        private System.Windows.Forms.PictureBox ammoHUD;
        private System.Windows.Forms.PictureBox bulletEnemy;
        private System.Windows.Forms.PictureBox youLose;
        private System.Windows.Forms.Button retryBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}