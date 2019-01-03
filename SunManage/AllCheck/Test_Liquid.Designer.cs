namespace SunManage.AllCheck
{
    partial class Test_Liquid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Liquid));
            this.labelCancel = new System.Windows.Forms.Label();
            this.labelOther = new System.Windows.Forms.Label();
            this.labelIsopropanol = new System.Windows.Forms.Label();
            this.labelAlcohol = new System.Windows.Forms.Label();
            this.labelWater = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCancel
            // 
            this.labelCancel.AutoSize = true;
            this.labelCancel.BackColor = System.Drawing.Color.Transparent;
            this.labelCancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCancel.ForeColor = System.Drawing.Color.Transparent;
            this.labelCancel.Location = new System.Drawing.Point(258, 196);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(47, 19);
            this.labelCancel.TabIndex = 11;
            this.labelCancel.Text = "取消";
            this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.BackColor = System.Drawing.Color.Transparent;
            this.labelOther.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOther.ForeColor = System.Drawing.Color.Transparent;
            this.labelOther.Location = new System.Drawing.Point(177, 150);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(58, 24);
            this.labelOther.TabIndex = 10;
            this.labelOther.Text = "其它";
            this.labelOther.Click += new System.EventHandler(this.labelOther_Click);
            // 
            // labelIsopropanol
            // 
            this.labelIsopropanol.AutoSize = true;
            this.labelIsopropanol.BackColor = System.Drawing.Color.Transparent;
            this.labelIsopropanol.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIsopropanol.ForeColor = System.Drawing.Color.Transparent;
            this.labelIsopropanol.Location = new System.Drawing.Point(59, 150);
            this.labelIsopropanol.Name = "labelIsopropanol";
            this.labelIsopropanol.Size = new System.Drawing.Size(82, 24);
            this.labelIsopropanol.TabIndex = 9;
            this.labelIsopropanol.Text = "异丙醇";
            this.labelIsopropanol.Click += new System.EventHandler(this.labelIsopropanol_Click);
            // 
            // labelAlcohol
            // 
            this.labelAlcohol.AutoSize = true;
            this.labelAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.labelAlcohol.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAlcohol.ForeColor = System.Drawing.Color.Transparent;
            this.labelAlcohol.Location = new System.Drawing.Point(177, 101);
            this.labelAlcohol.Name = "labelAlcohol";
            this.labelAlcohol.Size = new System.Drawing.Size(58, 24);
            this.labelAlcohol.TabIndex = 8;
            this.labelAlcohol.Text = "酒精";
            this.labelAlcohol.Click += new System.EventHandler(this.labelAlcohol_Click);
            // 
            // labelWater
            // 
            this.labelWater.BackColor = System.Drawing.Color.Transparent;
            this.labelWater.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWater.ForeColor = System.Drawing.Color.Transparent;
            this.labelWater.Location = new System.Drawing.Point(59, 101);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(82, 24);
            this.labelWater.TabIndex = 7;
            this.labelWater.Text = "水";
            this.labelWater.Click += new System.EventHandler(this.labelWater_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择测试液体：";
            // 
            // Test_Liquid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunManage.Properties.Resources.Test_Config;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 276);
            this.Controls.Add(this.labelCancel);
            this.Controls.Add(this.labelOther);
            this.Controls.Add(this.labelIsopropanol);
            this.Controls.Add(this.labelAlcohol);
            this.Controls.Add(this.labelWater);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test_Liquid";
            this.Text = "Test_Liquid";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Test_Liquid_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Test_Liquid_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Test_Liquid_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCancel;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Label labelIsopropanol;
        private System.Windows.Forms.Label labelAlcohol;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label label1;
    }
}