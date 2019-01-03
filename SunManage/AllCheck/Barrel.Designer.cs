namespace SunManage.AllCheck
{
    partial class Barrel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barrel));
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxTest_Filter_Num = new System.Windows.Forms.TextBox();
            this.textBoxTest_Filter_Hight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTrue = new System.Windows.Forms.Label();
            this.labelFalse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(12, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 14);
            this.label35.TabIndex = 20;
            this.label35.Text = "高度：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(12, 100);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 14);
            this.label34.TabIndex = 19;
            this.label34.Text = "数量：";
            // 
            // textBoxTest_Filter_Num
            // 
            this.textBoxTest_Filter_Num.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTest_Filter_Num.Location = new System.Drawing.Point(74, 98);
            this.textBoxTest_Filter_Num.Name = "textBoxTest_Filter_Num";
            this.textBoxTest_Filter_Num.Size = new System.Drawing.Size(163, 23);
            this.textBoxTest_Filter_Num.TabIndex = 30;
            this.textBoxTest_Filter_Num.Text = "1";
            // 
            // textBoxTest_Filter_Hight
            // 
            this.textBoxTest_Filter_Hight.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTest_Filter_Hight.Location = new System.Drawing.Point(74, 49);
            this.textBoxTest_Filter_Hight.Name = "textBoxTest_Filter_Hight";
            this.textBoxTest_Filter_Hight.Size = new System.Drawing.Size(163, 23);
            this.textBoxTest_Filter_Hight.TabIndex = 29;
            this.textBoxTest_Filter_Hight.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(251, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "inch";
            // 
            // labelTrue
            // 
            this.labelTrue.AutoSize = true;
            this.labelTrue.BackColor = System.Drawing.Color.Transparent;
            this.labelTrue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTrue.ForeColor = System.Drawing.Color.White;
            this.labelTrue.Location = new System.Drawing.Point(148, 153);
            this.labelTrue.Name = "labelTrue";
            this.labelTrue.Size = new System.Drawing.Size(35, 14);
            this.labelTrue.TabIndex = 40;
            this.labelTrue.Text = "确定";
            this.labelTrue.Click += new System.EventHandler(this.labelTrue_Click);
            // 
            // labelFalse
            // 
            this.labelFalse.AutoSize = true;
            this.labelFalse.BackColor = System.Drawing.Color.Transparent;
            this.labelFalse.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFalse.ForeColor = System.Drawing.Color.White;
            this.labelFalse.Location = new System.Drawing.Point(242, 153);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(35, 14);
            this.labelFalse.TabIndex = 41;
            this.labelFalse.Text = "取消";
            this.labelFalse.Click += new System.EventHandler(this.labelFalse_Click);
            // 
            // Barrel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunManage.Properties.Resources.Test_Config;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 216);
            this.Controls.Add(this.labelFalse);
            this.Controls.Add(this.labelTrue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTest_Filter_Num);
            this.Controls.Add(this.textBoxTest_Filter_Hight);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barrel";
            this.Text = "Barrel";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barrel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barrel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Barrel_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxTest_Filter_Num;
        private System.Windows.Forms.TextBox textBoxTest_Filter_Hight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTrue;
        private System.Windows.Forms.Label labelFalse;
    }
}