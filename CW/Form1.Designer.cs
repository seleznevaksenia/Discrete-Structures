namespace CW
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
            this.table = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.translate = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.automate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(26, 82);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(602, 466);
            this.table.TabIndex = 0;
            this.table.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(665, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Task";
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(645, 82);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(500, 202);
            this.task.TabIndex = 2;
            this.task.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "string for translation";
            // 
            // translate
            // 
            this.translate.Location = new System.Drawing.Point(645, 415);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(497, 46);
            this.translate.TabIndex = 4;
            this.translate.Text = "translate";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(646, 348);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(495, 22);
            this.input.TabIndex = 5;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(645, 526);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(494, 22);
            this.output.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "translation";
            // 
            // automate
            // 
            this.automate.Location = new System.Drawing.Point(26, 43);
            this.automate.Name = "automate";
            this.automate.Size = new System.Drawing.Size(602, 23);
            this.automate.TabIndex = 8;
            this.automate.Text = "automate\t";
            this.automate.UseVisualStyleBackColor = true;
            this.automate.Click += new System.EventHandler(this.automate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 590);
            this.Controls.Add(this.automate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.task);
            this.Controls.Add(this.label);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox table;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox task;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button automate;
    }
}

