namespace SunManage.AllCheck
{
    partial class Fluid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fluid));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFalse = new System.Windows.Forms.Label();
            this.labelTrue = new System.Windows.Forms.Label();
            this.textBoxTest_Filter_LiquidName = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = "请输入测试液体名称：";
            // 
            // labelFalse
            // 
            this.labelFalse.AutoSize = true;
            this.labelFalse.BackColor = System.Drawing.Color.Transparent;
            this.labelFalse.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFalse.ForeColor = System.Drawing.Color.White;
            this.labelFalse.Location = new System.Drawing.Point(289, 149);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(35, 14);
            this.labelFalse.TabIndex = 55;
            this.labelFalse.Text = "取消";
            this.labelFalse.Click += new System.EventHandler(this.labelFalse_Click);
            // 
            // labelTrue
            // 
            this.labelTrue.AutoSize = true;
            this.labelTrue.BackColor = System.Drawing.Color.Transparent;
            this.labelTrue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTrue.ForeColor = System.Drawing.Color.White;
            this.labelTrue.Location = new System.Drawing.Point(195, 149);
            this.labelTrue.Name = "labelTrue";
            this.labelTrue.Size = new System.Drawing.Size(35, 14);
            this.labelTrue.TabIndex = 54;
            this.labelTrue.Text = "确定";
            this.labelTrue.Click += new System.EventHandler(this.labelTrue_Click);
            // 
            // textBoxTest_Filter_LiquidName
            // 
            this.textBoxTest_Filter_LiquidName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTest_Filter_LiquidName.Location = new System.Drawing.Point(101, 80);
            this.textBoxTest_Filter_LiquidName.Name = "textBoxTest_Filter_LiquidName";
            this.textBoxTest_Filter_LiquidName.Size = new System.Drawing.Size(196, 23);
            this.textBoxTest_Filter_LiquidName.TabIndex = 52;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(39, 83);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 14);
            this.label35.TabIndex = 51;
            this.label35.Text = "名称：";
            // 
            // Fluid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SunManage.Properties.Resources.Test_Config;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFalse);
            this.Controls.Add(this.labelTrue);
            this.Controls.Add(this.textBoxTest_Filter_LiquidName);
            this.Controls.Add(this.label35);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fluid";
            this.Text = "Fluid";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fluid_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Fluid_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fluid_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFalse;
        private System.Windows.Forms.Label labelTrue;
        private System.Windows.Forms.TextBox textBoxTest_Filter_LiquidName;
        private System.Windows.Forms.Label label35;
    }
}