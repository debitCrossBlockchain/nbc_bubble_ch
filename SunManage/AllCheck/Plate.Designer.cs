namespace SunManage.AllCheck
{
    partial class Plate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plate));
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTest_Filter_Diameter = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.labelFalse = new System.Windows.Forms.Label();
            this.labelTrue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(262, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 42;
            this.label8.Text = "mm";
            // 
            // textBoxTest_Filter_Diameter
            // 
            this.textBoxTest_Filter_Diameter.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTest_Filter_Diameter.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTest_Filter_Diameter.Location = new System.Drawing.Point(78, 60);
            this.textBoxTest_Filter_Diameter.Name = "textBoxTest_Filter_Diameter";
            this.textBoxTest_Filter_Diameter.Size = new System.Drawing.Size(178, 23);
            this.textBoxTest_Filter_Diameter.TabIndex = 41;
            this.textBoxTest_Filter_Diameter.Text = "10";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(23, 63);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 14);
            this.label35.TabIndex = 40;
            this.label35.Text = "直径：";
            // 
            // labelFalse
            // 
            this.labelFalse.AutoSize = true;
            this.labelFalse.BackColor = System.Drawing.Color.Transparent;
            this.labelFalse.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFalse.ForeColor = System.Drawing.Color.White;
            this.labelFalse.Location = new System.Drawing.Point(266, 129);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(35, 14);
            this.labelFalse.TabIndex = 44;
            this.labelFalse.Text = "取消";
            this.labelFalse.Click += new System.EventHandler(this.labelFalse_Click);
            // 
            // labelTrue
            // 
            this.labelTrue.AutoSize = true;
            this.labelTrue.BackColor = System.Drawing.Color.Transparent;
            this.labelTrue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTrue.ForeColor = System.Drawing.Color.White;
            this.labelTrue.Location = new System.Drawing.Point(172, 129);
            this.labelTrue.Name = "labelTrue";
            this.labelTrue.Size = new System.Drawing.Size(35, 14);
            this.labelTrue.TabIndex = 43;
            this.labelTrue.Text = "确定";
            this.labelTrue.Click += new System.EventHandler(this.labelTrue_Click);
            // 
            // Plate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunManage.Properties.Resources.Test_Config;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 216);
            this.Controls.Add(this.labelFalse);
            this.Controls.Add(this.labelTrue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTest_Filter_Diameter);
            this.Controls.Add(this.label35);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plate";
            this.Text = "Plate";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Plate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Plate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Plate_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTest_Filter_Diameter;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label labelFalse;
        private System.Windows.Forms.Label labelTrue;
    }
}