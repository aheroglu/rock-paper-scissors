namespace rock_paper_scissors.Forms
{
    partial class form_game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_game));
            this.label_count = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_pc_choice = new System.Windows.Forms.PictureBox();
            this.picture_user_choice = new System.Windows.Forms.PictureBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_you_chose = new System.Windows.Forms.Label();
            this.label_pc_chose = new System.Windows.Forms.Label();
            this.button_play_again = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pc_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_choice)).BeginInit();
            this.SuspendLayout();
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.BackColor = System.Drawing.Color.Transparent;
            this.label_count.Font = new System.Drawing.Font("Corbel", 64F);
            this.label_count.Location = new System.Drawing.Point(430, 164);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(84, 105);
            this.label_count.TabIndex = 1;
            this.label_count.Text = "3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picture_pc_choice
            // 
            this.picture_pc_choice.BackColor = System.Drawing.Color.Transparent;
            this.picture_pc_choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_pc_choice.Location = new System.Drawing.Point(497, 98);
            this.picture_pc_choice.Name = "picture_pc_choice";
            this.picture_pc_choice.Size = new System.Drawing.Size(259, 280);
            this.picture_pc_choice.TabIndex = 6;
            this.picture_pc_choice.TabStop = false;
            // 
            // picture_user_choice
            // 
            this.picture_user_choice.BackColor = System.Drawing.Color.Transparent;
            this.picture_user_choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_user_choice.Location = new System.Drawing.Point(177, 98);
            this.picture_user_choice.Name = "picture_user_choice";
            this.picture_user_choice.Size = new System.Drawing.Size(259, 280);
            this.picture_user_choice.TabIndex = 7;
            this.picture_user_choice.TabStop = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Corbel", 48F);
            this.label_status.Location = new System.Drawing.Point(340, 13);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(265, 78);
            this.label_status.TabIndex = 8;
            this.label_status.Text = "You Win!";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_status.Visible = false;
            // 
            // label_you_chose
            // 
            this.label_you_chose.AutoSize = true;
            this.label_you_chose.BackColor = System.Drawing.Color.Transparent;
            this.label_you_chose.Font = new System.Drawing.Font("Corbel", 32F);
            this.label_you_chose.Location = new System.Drawing.Point(204, 397);
            this.label_you_chose.Name = "label_you_chose";
            this.label_you_chose.Size = new System.Drawing.Size(207, 53);
            this.label_you_chose.TabIndex = 9;
            this.label_you_chose.Text = "You Chose";
            this.label_you_chose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_you_chose.Visible = false;
            // 
            // label_pc_chose
            // 
            this.label_pc_chose.AutoSize = true;
            this.label_pc_chose.BackColor = System.Drawing.Color.Transparent;
            this.label_pc_chose.Font = new System.Drawing.Font("Corbel", 32F);
            this.label_pc_chose.Location = new System.Drawing.Point(535, 397);
            this.label_pc_chose.Name = "label_pc_chose";
            this.label_pc_chose.Size = new System.Drawing.Size(189, 53);
            this.label_pc_chose.TabIndex = 10;
            this.label_pc_chose.Text = "PC Chose";
            this.label_pc_chose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pc_chose.Visible = false;
            // 
            // button_play_again
            // 
            this.button_play_again.BackColor = System.Drawing.Color.Transparent;
            this.button_play_again.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play_again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play_again.Location = new System.Drawing.Point(389, 479);
            this.button_play_again.Name = "button_play_again";
            this.button_play_again.Size = new System.Drawing.Size(155, 44);
            this.button_play_again.TabIndex = 11;
            this.button_play_again.Text = "Play Again";
            this.button_play_again.UseVisualStyleBackColor = false;
            this.button_play_again.Visible = false;
            this.button_play_again.Click += new System.EventHandler(this.button_play_again_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(893, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 30);
            this.button_close.TabIndex = 12;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 545);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_play_again);
            this.Controls.Add(this.label_pc_chose);
            this.Controls.Add(this.label_you_chose);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.picture_user_choice);
            this.Controls.Add(this.picture_pc_choice);
            this.Controls.Add(this.label_count);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.picture_pc_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user_choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picture_pc_choice;
        private System.Windows.Forms.PictureBox picture_user_choice;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_you_chose;
        private System.Windows.Forms.Label label_pc_chose;
        private System.Windows.Forms.Button button_play_again;
        private System.Windows.Forms.Button button_close;
    }
}