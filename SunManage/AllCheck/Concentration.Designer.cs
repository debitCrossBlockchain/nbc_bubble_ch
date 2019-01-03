namespace SunManage.AllCheck
{
    partial class Concentration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concentration));
            this.labelFalse = new System.Windows.Forms.Label();
            this.labelTrue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTest_Filter_Concentration = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFalse
            // 
            this.labelFalse.AutoSize = true;
            this.labelFalse.BackColor = System.Drawing.Color.Transparent;
            this.labelFalse.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFalse.ForeColor = System.Drawing.Color.Transparent;
            this.labelFalse.Location = new System.Drawing.Point(273, 170);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(35, 14);
            this.labelFalse.TabIndex = 49;
            this.labelFalse.Text = "取消";
            this.labelFalse.Click += new System.EventHandler(this.labelFalse_Click);
            // 
            // labelTrue
            // 
            this.labelTrue.AutoSize = true;
            this.labelTrue.BackColor = System.Drawing.Color.Transparent;
            this.labelTrue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTrue.ForeColor = System.Drawing.Color.Transparent;
            this.labelTrue.Location = new System.Drawing.Point(179, 170);
            this.labelTrue.Name = "labelTrue";
            this.labelTrue.Size = new System.Drawing.Size(35, 14);
            this.labelTrue.TabIndex = 48;
            this.labelTrue.Text = "确定";
            this.labelTrue.Click += new System.EventHandler(this.labelTrue_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(277, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "%";
            // 
            // textBoxTest_Filter_Concentration
            // 
            this.textBoxTest_Filter_Concentration.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTest_Filter_Concentration.Location = new System.Drawing.Point(85, 101);
            this.textBoxTest_Filter_Concentration.Name = "textBoxTest_Filter_Concentration";
            this.textBoxTest_Filter_Concentration.Size = new System.Drawing.Size(178, 23);
            this.textBoxTest_Filter_Concentration.TabIndex = 46;
            this.textBoxTest_Filter_Concentration.Text = "10";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(30, 104);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 14);
            this.label35.TabIndex = 45;
            this.label35.Text = "浓度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "请输入测试液体浓度：";
            // 
            // Concentration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunManage.Properties.Resources.Test_Config;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFalse);
            this.Controls.Add(this.labelTrue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTest_Filter_Concentration);
            this.Controls.Add(this.label35);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concentration";
            this.Text = "Concentration";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Concentration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Concentration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Concentration_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFalse;
        private System.Windows.Forms.Label labelTrue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTest_Filter_Concentration;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label1;
    }
}