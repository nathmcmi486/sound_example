using System.Media;

namespace sound_example
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_text = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.main_text.AutoSize = true;
            this.main_text.Location = new System.Drawing.Point(0, 0);
            this.main_text.Name = "main_text";
            this.main_text.Size = new System.Drawing.Size(38, 15);
            this.main_text.TabIndex = 0;
            this.main_text.Text = "My sound example";

            // button
            this.button = new System.Windows.Forms.Button();
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(125, 60);
            this.button.Location = new System.Drawing.Point(200, 50);
            this.button.Text = "Play Sound";
            this.button.BackColor = System.Drawing.Color.Blue;
            this.button.Click += new EventHandler(button_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_text);
            this.Controls.Add(this.button);
            // this.Controls.Add(this.sound_player);
            this.Name = "Form1";
            this.Text = "Sound Test";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        /*
         * 
         *
        */
        private void button_Click(object sender, EventArgs e)
        {
            // sound_player
            // TODO: get sound file
            this.main_text.Text = "A sound should have been played";

            System.Console.WriteLine("Here\n");
            try
            {
                if (button_clicked)
                {
                    this.main_text.Text = "A different sound should've been played";
                    this.BackColor = Color.DarkCyan;
                    this.sound_player.SoundLocation = "/maybe/a/different/path".ToString();
                } else
                {
                    this.sound_player.SoundLocation = "/this/is/a/test/path".ToString();
                }
                this.sound_player.Load();
                this.sound_player.Play();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("This is not working\n");
                System.Console.WriteLine(ex.Message);
            }

            if (button_clicked)
            {
                this.button = null;
            }

            button_clicked = true;
        }

        private Label main_text;
        //private Label not_important_text;
        private Button button;
        private SoundPlayer sound_player;
        private bool button_clicked = false;

    }
}