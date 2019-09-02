namespace WindowsFormsApp1
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
            this.UpdField = new System.Windows.Forms.Button();
            this.run_workflow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdField
            // 
            this.UpdField.Location = new System.Drawing.Point(41, 69);
            this.UpdField.Name = "UpdField";
            this.UpdField.Size = new System.Drawing.Size(236, 62);
            this.UpdField.TabIndex = 0;
            this.UpdField.Text = "Update Field";
            this.UpdField.UseVisualStyleBackColor = true;
            this.UpdField.Click += new System.EventHandler(this.Button1_Click);
            // 
            // run_workflow
            // 
            this.run_workflow.Location = new System.Drawing.Point(41, 168);
            this.run_workflow.Name = "run_workflow";
            this.run_workflow.Size = new System.Drawing.Size(234, 62);
            this.run_workflow.TabIndex = 1;
            this.run_workflow.Text = "Run Workflow";
            this.run_workflow.UseVisualStyleBackColor = true;
            this.run_workflow.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 521);
            this.Controls.Add(this.run_workflow);
            this.Controls.Add(this.UpdField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdField;
        private System.Windows.Forms.Button run_workflow;
    }
}

