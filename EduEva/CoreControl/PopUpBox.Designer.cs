namespace EduEva.CoreControl
{
    partial class PopUpBox
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
            this.PopUpSheetPlugIn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PopUpSheetPlugIn
            // 
            this.PopUpSheetPlugIn.Location = new System.Drawing.Point(3, 2);
            this.PopUpSheetPlugIn.Name = "PopUpSheetPlugIn";
            this.PopUpSheetPlugIn.Size = new System.Drawing.Size(441, 269);
            this.PopUpSheetPlugIn.TabIndex = 0;
            // 
            // PopUpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 275);
            this.ControlBox = false;
            this.Controls.Add(this.PopUpSheetPlugIn);
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "PopUpBox";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PopUpSheetPlugIn;
    }
}