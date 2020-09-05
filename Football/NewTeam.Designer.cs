namespace Football
{
    partial class NewTeam
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTeam = new System.Windows.Forms.TextBox();
            this.NameCoach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить команду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название команды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите имя тренера";
            // 
            // NameTeam
            // 
            this.NameTeam.Location = new System.Drawing.Point(174, 70);
            this.NameTeam.Name = "NameTeam";
            this.NameTeam.Size = new System.Drawing.Size(100, 22);
            this.NameTeam.TabIndex = 3;
            // 
            // NameCoach
            // 
            this.NameCoach.Location = new System.Drawing.Point(174, 163);
            this.NameCoach.Name = "NameCoach";
            this.NameCoach.Size = new System.Drawing.Size(100, 22);
            this.NameCoach.TabIndex = 4;
            // 
            // NewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameCoach);
            this.Controls.Add(this.NameTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "NewTeam";
            this.Text = "NewTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTeam;
        private System.Windows.Forms.TextBox NameCoach;
    }
}