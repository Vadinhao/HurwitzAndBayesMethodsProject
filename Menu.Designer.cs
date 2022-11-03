
namespace HurwitzAndBayesMethodsProject
{
    partial class Menu
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
            this.TabControlMenu = new System.Windows.Forms.TabControl();
            this.tabTheory = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTests = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPractice = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLogOut = new System.Windows.Forms.TabPage();
            this.tabExit = new System.Windows.Forms.TabPage();
            this.TabControlMenu.SuspendLayout();
            this.tabTheory.SuspendLayout();
            this.tabTests.SuspendLayout();
            this.tabPractice.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMenu
            // 
            this.TabControlMenu.Controls.Add(this.tabTheory);
            this.TabControlMenu.Controls.Add(this.tabTests);
            this.TabControlMenu.Controls.Add(this.tabPractice);
            this.TabControlMenu.Controls.Add(this.tabStatistics);
            this.TabControlMenu.Controls.Add(this.tabLogOut);
            this.TabControlMenu.Controls.Add(this.tabExit);
            this.TabControlMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.TabControlMenu.Name = "TabControlMenu";
            this.TabControlMenu.SelectedIndex = 0;
            this.TabControlMenu.Size = new System.Drawing.Size(784, 462);
            this.TabControlMenu.TabIndex = 0;
            this.TabControlMenu.SelectedIndexChanged += new System.EventHandler(this.TabControlMenu_SelectedIndexChanged);
            // 
            // Theory
            // 
            this.tabTheory.Controls.Add(this.label1);
            this.tabTheory.Location = new System.Drawing.Point(4, 34);
            this.tabTheory.Name = "tabTheory";
            this.tabTheory.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheory.Size = new System.Drawing.Size(776, 424);
            this.tabTheory.TabIndex = 0;
            this.tabTheory.Text = "Theory";
            this.tabTheory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Теория";
            // 
            // Tests
            // 
            this.tabTests.Controls.Add(this.label2);
            this.tabTests.Location = new System.Drawing.Point(4, 34);
            this.tabTests.Name = "tabTests";
            this.tabTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabTests.Size = new System.Drawing.Size(776, 424);
            this.tabTests.TabIndex = 1;
            this.tabTests.Text = "Tests";
            this.tabTests.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тесты";
            // 
            // Practice
            // 
            this.tabPractice.Controls.Add(this.label3);
            this.tabPractice.Location = new System.Drawing.Point(4, 34);
            this.tabPractice.Name = "tabPractice";
            this.tabPractice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPractice.Size = new System.Drawing.Size(776, 424);
            this.tabPractice.TabIndex = 2;
            this.tabPractice.Text = "Practice";
            this.tabPractice.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Практика";
            // 
            // Statistics
            // 
            this.tabStatistics.Controls.Add(this.label4);
            this.tabStatistics.Location = new System.Drawing.Point(4, 34);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(776, 424);
            this.tabStatistics.TabIndex = 3;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Статистика";
            // 
            // LogOut
            // 
            this.tabLogOut.Location = new System.Drawing.Point(4, 34);
            this.tabLogOut.Name = "tabLogOut";
            this.tabLogOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogOut.Size = new System.Drawing.Size(776, 424);
            this.tabLogOut.TabIndex = 4;
            this.tabLogOut.Text = "LogOut";
            this.tabLogOut.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.tabExit.Location = new System.Drawing.Point(4, 34);
            this.tabExit.Name = "tabExit";
            this.tabExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabExit.Size = new System.Drawing.Size(776, 424);
            this.tabExit.TabIndex = 5;
            this.tabExit.Text = "Exit";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TabControlMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.TabControlMenu.ResumeLayout(false);
            this.tabTheory.ResumeLayout(false);
            this.tabTheory.PerformLayout();
            this.tabTests.ResumeLayout(false);
            this.tabTests.PerformLayout();
            this.tabPractice.ResumeLayout(false);
            this.tabPractice.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMenu;
        private System.Windows.Forms.TabPage tabTheory;
        private System.Windows.Forms.TabPage tabTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPractice;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabPage tabLogOut;
        private System.Windows.Forms.TabPage tabExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}