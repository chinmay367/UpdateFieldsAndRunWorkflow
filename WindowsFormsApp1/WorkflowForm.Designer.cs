namespace WindowsFormsApp1
{
    partial class WorkflowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkflwTbox = new System.Windows.Forms.TextBox();
            this.RecordTbox = new System.Windows.Forms.TextBox();
            this.RunWfl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workflow Id";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Record Id";
            // 
            // WorkflwTbox
            // 
            this.WorkflwTbox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkflwTbox.Location = new System.Drawing.Point(273, 90);
            this.WorkflwTbox.Name = "WorkflwTbox";
            this.WorkflwTbox.Size = new System.Drawing.Size(312, 30);
            this.WorkflwTbox.TabIndex = 2;
            this.WorkflwTbox.TextChanged += new System.EventHandler(this.WorkflwTbox_TextChanged);
            // 
            // RecordTbox
            // 
            this.RecordTbox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordTbox.Location = new System.Drawing.Point(273, 174);
            this.RecordTbox.Name = "RecordTbox";
            this.RecordTbox.Size = new System.Drawing.Size(312, 30);
            this.RecordTbox.TabIndex = 3;
            this.RecordTbox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // RunWfl
            // 
            this.RunWfl.Location = new System.Drawing.Point(273, 288);
            this.RunWfl.Name = "RunWfl";
            this.RunWfl.Size = new System.Drawing.Size(195, 48);
            this.RunWfl.TabIndex = 4;
            this.RunWfl.Text = "Run Workflow";
            this.RunWfl.UseVisualStyleBackColor = true;
            this.RunWfl.Click += new System.EventHandler(this.RunWfl_Click);
            // 
            // WorkflowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunWfl);
            this.Controls.Add(this.RecordTbox);
            this.Controls.Add(this.WorkflwTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkflowForm";
            this.Text = "WorkflowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WorkflwTbox;
        private System.Windows.Forms.TextBox RecordTbox;
        private System.Windows.Forms.Button RunWfl;
    }
}