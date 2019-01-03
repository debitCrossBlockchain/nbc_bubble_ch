namespace SunManage.communication
{
    partial class Import
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.imageListInfo = new System.Windows.Forms.ImageList(this.components);
            this.buttonLoadSQL = new System.Windows.Forms.Button();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogtxt = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // imageListInfo
            // 
            this.imageListInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListInfo.ImageStream")));
            this.imageListInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListInfo.Images.SetKeyName(0, "word.png");
            this.imageListInfo.Images.SetKeyName(1, "usb.png");
            this.imageListInfo.Images.SetKeyName(2, "container.png");
            this.imageListInfo.Images.SetKeyName(3, "pic.png");
            this.imageListInfo.Images.SetKeyName(4, "pdf.png");
            this.imageListInfo.Images.SetKeyName(5, "so.jpg");
            // 
            // buttonLoadSQL
            // 
            this.buttonLoadSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadSQL.Location = new System.Drawing.Point(40, 12);
            this.buttonLoadSQL.Name = "buttonLoadSQL";
            this.buttonLoadSQL.Size = new System.Drawing.Size(209, 27);
            this.buttonLoadSQL.TabIndex = 2;
            this.buttonLoadSQL.Text = "打开并导入数据库";
            this.buttonLoadSQL.UseVisualStyleBackColor = true;
            this.buttonLoadSQL.Click += new System.EventHandler(this.buttonLoadSQL_Click);
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 3000;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // openFileDialogtxt
            // 
            this.openFileDialogtxt.FileName = "openFileDialogtxt";
            this.openFileDialogtxt.Multiselect = true;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 56);
            this.Controls.Add(this.buttonLoadSQL);
            this.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Import";
            this.Text = "导入";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.ImageList imageListInfo;
        private System.Windows.Forms.Button buttonLoadSQL;
        private System.Windows.Forms.OpenFileDialog openFileDialogtxt;
    }
}