﻿namespace _2
{
    partial class Form1
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
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.computer = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::_2.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(12, 131);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 120);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::_2.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(385, 165);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(35, 35);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // computer
            // 
            this.computer.Image = global::_2.Properties.Resources.computer;
            this.computer.Location = new System.Drawing.Point(758, 146);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(30, 120);
            this.computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computer.TabIndex = 2;
            this.computer.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Player: 0 -- Computer: 0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeylsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeylsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox computer;
        private System.Windows.Forms.Timer GameTimer;
    }
}

