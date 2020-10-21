namespace ChuckNorrisApp
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
            this.GetJokeBtn = new System.Windows.Forms.Button();
            this.JokeCategoryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetJokeBtn
            // 
            this.GetJokeBtn.Location = new System.Drawing.Point(486, 289);
            this.GetJokeBtn.Name = "GetJokeBtn";
            this.GetJokeBtn.Size = new System.Drawing.Size(121, 71);
            this.GetJokeBtn.TabIndex = 0;
            this.GetJokeBtn.Text = "Get Joke";
            this.GetJokeBtn.UseVisualStyleBackColor = true;
            this.GetJokeBtn.Click += new System.EventHandler(this.GetJokeBtn_Click);
            // 
            // JokeCategoryBox
            // 
            this.JokeCategoryBox.FormattingEnabled = true;
            this.JokeCategoryBox.Location = new System.Drawing.Point(486, 169);
            this.JokeCategoryBox.Name = "JokeCategoryBox";
            this.JokeCategoryBox.Size = new System.Drawing.Size(121, 21);
            this.JokeCategoryBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JokeCategoryBox);
            this.Controls.Add(this.GetJokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetJokeBtn;
        private System.Windows.Forms.ComboBox JokeCategoryBox;
        private System.Windows.Forms.Label label1;
    }
}

