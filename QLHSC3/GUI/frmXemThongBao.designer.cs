namespace QLHSC3.GUI
{
    partial class frmXemThongBao
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lvThongBao = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.tenThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noiDungThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(126, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Danh sách thông báo:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(455, 207);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(155, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(202, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "XEM PHIẾU THÔNG BÁO";
            // 
            // lvThongBao
            // 
            // 
            // 
            // 
            this.lvThongBao.Border.Class = "ListViewBorder";
            this.lvThongBao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvThongBao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenThongBao,
            this.noiDungThongBao,
            this.ngayThongBao});
            this.lvThongBao.FullRowSelect = true;
            this.lvThongBao.GridLines = true;
            this.lvThongBao.Location = new System.Drawing.Point(12, 44);
            this.lvThongBao.MultiSelect = false;
            this.lvThongBao.Name = "lvThongBao";
            this.lvThongBao.Size = new System.Drawing.Size(518, 157);
            this.lvThongBao.TabIndex = 31;
            this.lvThongBao.UseCompatibleStateImageBehavior = false;
            this.lvThongBao.View = System.Windows.Forms.View.Details;
            // 
            // tenThongBao
            // 
            this.tenThongBao.Text = "Tên thông báo";
            this.tenThongBao.Width = 150;
            // 
            // noiDungThongBao
            // 
            this.noiDungThongBao.Text = "Nội dung thông báo";
            this.noiDungThongBao.Width = 250;
            // 
            // ngayThongBao
            // 
            this.ngayThongBao.Text = "Ngày thông báo";
            this.ngayThongBao.Width = 120;
            // 
            // frmXemThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 249);
            this.Controls.Add(this.lvThongBao);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmXemThongBao";
            this.Text = "Xem thông báo";
            this.Load += new System.EventHandler(this.NhanPhieuMoi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ListViewEx lvThongBao;
        private System.Windows.Forms.ColumnHeader tenThongBao;
        private System.Windows.Forms.ColumnHeader noiDungThongBao;
        private System.Windows.Forms.ColumnHeader ngayThongBao;
    }
}