namespace OrbitInjector
{
    partial class ProcessListUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_attachproc = new System.Windows.Forms.Button();
            this.button_refreshproc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a Process/Application";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Loading..."});
            this.comboBox1.Location = new System.Drawing.Point(11, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button_attachproc
            // 
            this.button_attachproc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_attachproc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_attachproc.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button_attachproc.FlatAppearance.BorderSize = 0;
            this.button_attachproc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_attachproc.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_attachproc.ForeColor = System.Drawing.Color.Lime;
            this.button_attachproc.Location = new System.Drawing.Point(29, 77);
            this.button_attachproc.Name = "button_attachproc";
            this.button_attachproc.Size = new System.Drawing.Size(75, 23);
            this.button_attachproc.TabIndex = 3;
            this.button_attachproc.Text = "Attach";
            this.button_attachproc.UseVisualStyleBackColor = true;
            this.button_attachproc.Click += new System.EventHandler(this.button_attachproc_Click);
            // 
            // button_refreshproc
            // 
            this.button_refreshproc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_refreshproc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_refreshproc.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button_refreshproc.FlatAppearance.BorderSize = 0;
            this.button_refreshproc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refreshproc.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refreshproc.ForeColor = System.Drawing.Color.Lime;
            this.button_refreshproc.Location = new System.Drawing.Point(29, 106);
            this.button_refreshproc.Name = "button_refreshproc";
            this.button_refreshproc.Size = new System.Drawing.Size(75, 23);
            this.button_refreshproc.TabIndex = 4;
            this.button_refreshproc.Text = "refresh";
            this.button_refreshproc.UseVisualStyleBackColor = true;
            this.button_refreshproc.Click += new System.EventHandler(this.button_refreshproc_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.button_refreshproc);
            this.Controls.Add(this.button_attachproc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(146, 159);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_attachproc;
        private System.Windows.Forms.Button button_refreshproc;
    }
}
