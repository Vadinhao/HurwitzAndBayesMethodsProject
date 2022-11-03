
namespace HurwitzAndBayesMethodsProject
{
    partial class Title
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
            this.TitleExitButton = new System.Windows.Forms.Button();
            this.TitleStartButton = new System.Windows.Forms.Button();
            this.TitleNextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleExitButton
            // 
            this.TitleExitButton.Location = new System.Drawing.Point(12, 415);
            this.TitleExitButton.Name = "TitleExitButton";
            this.TitleExitButton.Size = new System.Drawing.Size(75, 23);
            this.TitleExitButton.TabIndex = 0;
            this.TitleExitButton.Text = "Exit";
            this.TitleExitButton.UseVisualStyleBackColor = true;
            this.TitleExitButton.Click += new System.EventHandler(this.TitleExitButton_Click);
            // 
            // TitleStartButton
            // 
            this.TitleStartButton.Location = new System.Drawing.Point(713, 415);
            this.TitleStartButton.Name = "TitleStartButton";
            this.TitleStartButton.Size = new System.Drawing.Size(75, 23);
            this.TitleStartButton.TabIndex = 1;
            this.TitleStartButton.Text = "Start";
            this.TitleStartButton.UseVisualStyleBackColor = true;
            this.TitleStartButton.Click += new System.EventHandler(this.TitleStartButton_Click);
            // 
            // TitleNextButton
            // 
            this.TitleNextButton.Location = new System.Drawing.Point(680, 386);
            this.TitleNextButton.Name = "TitleNextButton";
            this.TitleNextButton.Size = new System.Drawing.Size(75, 23);
            this.TitleNextButton.TabIndex = 2;
            this.TitleNextButton.Text = "Next";
            this.TitleNextButton.UseVisualStyleBackColor = true;
            this.TitleNextButton.Click += new System.EventHandler(this.TitleNextButton_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleNextButton);
            this.Controls.Add(this.TitleStartButton);
            this.Controls.Add(this.TitleExitButton);
            this.Name = "Title";
            this.Text = "Title";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TitleExitButton;
        private System.Windows.Forms.Button TitleStartButton;
        private System.Windows.Forms.Button TitleNextButton;
    }
}

