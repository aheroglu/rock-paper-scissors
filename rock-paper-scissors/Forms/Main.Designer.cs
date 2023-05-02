namespace rock_paper_scissors.Forms
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.button_rock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_paper = new System.Windows.Forms.Button();
            this.button_scissors = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_rock
            // 
            this.button_rock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rock.BackgroundImage")));
            this.button_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rock.FlatAppearance.BorderSize = 0;
            this.button_rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rock.Location = new System.Drawing.Point(42, 144);
            this.button_rock.Name = "button_rock";
            this.button_rock.Size = new System.Drawing.Size(259, 280);
            this.button_rock.TabIndex = 0;
            this.button_rock.UseVisualStyleBackColor = true;
            this.button_rock.Click += new System.EventHandler(this.button_rock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your";
            // 
            // button_paper
            // 
            this.button_paper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_paper.BackgroundImage")));
            this.button_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_paper.FlatAppearance.BorderSize = 0;
            this.button_paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paper.Location = new System.Drawing.Point(328, 144);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(259, 280);
            this.button_paper.TabIndex = 2;
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.button_paper_Click);
            // 
            // button_scissors
            // 
            this.button_scissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_scissors.BackgroundImage")));
            this.button_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_scissors.FlatAppearance.BorderSize = 0;
            this.button_scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scissors.Location = new System.Drawing.Point(620, 144);
            this.button_scissors.Name = "button_scissors";
            this.button_scissors.Size = new System.Drawing.Size(259, 280);
            this.button_scissors.TabIndex = 3;
            this.button_scissors.UseVisualStyleBackColor = true;
            this.button_scissors.Click += new System.EventHandler(this.button_scissors_Click);
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
            this.button_close.TabIndex = 13;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 488);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_scissors);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_rock);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.Button button_scissors;
        private System.Windows.Forms.Button button_close;
    }
}