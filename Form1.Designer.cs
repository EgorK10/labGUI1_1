
namespace labGUI1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_solution = new System.Windows.Forms.Button();
            this.Word1 = new System.Windows.Forms.TextBox();
            this.Word2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_solution
            // 
            this.button_solution.BackColor = System.Drawing.SystemColors.Info;
            this.button_solution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_solution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_solution.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_solution.Location = new System.Drawing.Point(0, 351);
            this.button_solution.Name = "button_solution";
            this.button_solution.Size = new System.Drawing.Size(520, 59);
            this.button_solution.TabIndex = 0;
            this.button_solution.Text = "Решить";
            this.button_solution.UseVisualStyleBackColor = false;
            this.button_solution.Click += new System.EventHandler(this.button_solution_Click);
            // 
            // Word1
            // 
            this.Word1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word1.Location = new System.Drawing.Point(243, 171);
            this.Word1.MaxLength = 18;
            this.Word1.Name = "Word1";
            this.Word1.Size = new System.Drawing.Size(205, 27);
            this.Word1.TabIndex = 1;
            // 
            // Word2
            // 
            this.Word2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word2.Location = new System.Drawing.Point(243, 221);
            this.Word2.MaxLength = 18;
            this.Word2.Name = "Word2";
            this.Word2.Size = new System.Drawing.Size(205, 27);
            this.Word2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первое слово:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Второе слово:";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_answer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_answer.Location = new System.Drawing.Point(153, 274);
            this.label_answer.MaximumSize = new System.Drawing.Size(280, 50);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(73, 20);
            this.label_answer.TabIndex = 6;
            this.label_answer.Text = "Ответ: ";
            this.label_answer.Visible = false;
            // 
            // task
            // 
            this.task.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.task.AutoSize = true;
            this.task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.task.Location = new System.Drawing.Point(12, 9);
            this.task.Margin = new System.Windows.Forms.Padding(0);
            this.task.MaximumSize = new System.Drawing.Size(529, 150);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(499, 110);
            this.task.TabIndex = 7;
            this.task.Text = resources.GetString("task.Text");
            this.task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.Info;
            this.button_clear.BackgroundImage = global::labGUI1.Properties.Resources.bucket;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Location = new System.Drawing.Point(454, 186);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(45, 44);
            this.button_clear.TabIndex = 8;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(520, 410);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.task);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Word2);
            this.Controls.Add(this.Word1);
            this.Controls.Add(this.button_solution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_solution;
        private System.Windows.Forms.TextBox Word1;
        private System.Windows.Forms.TextBox Word2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Button button_clear;
    }
}

