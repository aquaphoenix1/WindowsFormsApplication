namespace WindowsFormsApplication.Elements
{
    partial class PinControl
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
            this.checkBoxConnected = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxConnected
            // 
            this.checkBoxConnected.AllowDrop = true;
            this.checkBoxConnected.AutoSize = true;
            this.checkBoxConnected.Enabled = false;
            this.checkBoxConnected.Location = new System.Drawing.Point(4, 17);
            this.checkBoxConnected.Name = "checkBoxConnected";
            this.checkBoxConnected.Size = new System.Drawing.Size(15, 14);
            this.checkBoxConnected.TabIndex = 0;
            this.checkBoxConnected.UseVisualStyleBackColor = true;
            this.checkBoxConnected.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkBoxConnected_DragDrop);
            this.checkBoxConnected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkBoxConnected_MouseDown);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // PinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBoxConnected);
            this.Name = "PinControl";
            this.Size = new System.Drawing.Size(68, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxConnected;
        private System.Windows.Forms.Label labelName;
    }
}
