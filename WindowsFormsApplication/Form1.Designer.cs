namespace WindowsFormsApplication
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelElements = new System.Windows.Forms.FlowLayoutPanel();
            this.panelScrollMain = new System.Windows.Forms.Panel();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.panelScrollMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelElements
            // 
            this.panelElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelElements.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelElements.Location = new System.Drawing.Point(842, 12);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(92, 426);
            this.panelElements.TabIndex = 0;
            // 
            // panelScrollMain
            // 
            this.panelScrollMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScrollMain.AutoScroll = true;
            this.panelScrollMain.Controls.Add(this.panelConnection);
            this.panelScrollMain.Location = new System.Drawing.Point(13, 12);
            this.panelScrollMain.Name = "panelScrollMain";
            this.panelScrollMain.Size = new System.Drawing.Size(823, 426);
            this.panelScrollMain.TabIndex = 1;
            // 
            // panelConnection
            // 
            this.panelConnection.AllowDrop = true;
            this.panelConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelConnection.Location = new System.Drawing.Point(3, 3);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(5000, 5000);
            this.panelConnection.TabIndex = 3;
            this.panelConnection.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelConnection_DragDrop);
            this.panelConnection.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelConnection_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.panelScrollMain);
            this.Controls.Add(this.panelElements);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelScrollMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelElements;
        private System.Windows.Forms.Panel panelScrollMain;
        private System.Windows.Forms.Panel panelConnection;
    }
}

