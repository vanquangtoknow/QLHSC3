namespace QLHSC3.GUI
{
    partial class frmLapThongBao
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbxTenThongBao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxNoiDungThongBao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtNgayThongBao = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.lvThongBao = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.maThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noiDungThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayThongBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên thông báo:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(34, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(104, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Nội dung thông báo: ";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Blue;
            this.labelX3.Location = new System.Drawing.Point(166, 1);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(202, 23);
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "LẬP PHIẾU THÔNG BÁO";
            // 
            // tbxTenThongBao
            // 
            this.tbxTenThongBao.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.tbxTenThongBao.Border.Class = "TextBoxBorder";
            this.tbxTenThongBao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxTenThongBao.Location = new System.Drawing.Point(211, 30);
            this.tbxTenThongBao.Name = "tbxTenThongBao";
            this.tbxTenThongBao.Size = new System.Drawing.Size(344, 20);
            this.tbxTenThongBao.TabIndex = 1;
            // 
            // tbxNoiDungThongBao
            // 
            this.tbxNoiDungThongBao.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.tbxNoiDungThongBao.Border.Class = "TextBoxBorder";
            this.tbxNoiDungThongBao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxNoiDungThongBao.Location = new System.Drawing.Point(34, 89);
            this.tbxNoiDungThongBao.Multiline = true;
            this.tbxNoiDungThongBao.Name = "tbxNoiDungThongBao";
            this.tbxNoiDungThongBao.Size = new System.Drawing.Size(521, 76);
            this.tbxNoiDungThongBao.TabIndex = 3;
            // 
            // dtNgayThongBao
            // 
            // 
            // 
            // 
            this.dtNgayThongBao.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayThongBao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThongBao.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayThongBao.ButtonDropDown.Visible = true;
            this.dtNgayThongBao.Location = new System.Drawing.Point(335, 56);
            // 
            // 
            // 
            this.dtNgayThongBao.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayThongBao.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayThongBao.MonthCalendar.BackgroundStyle.Class = "";
            this.dtNgayThongBao.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThongBao.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtNgayThongBao.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThongBao.MonthCalendar.DisplayMonth = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtNgayThongBao.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayThongBao.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayThongBao.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayThongBao.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayThongBao.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayThongBao.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtNgayThongBao.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThongBao.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayThongBao.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayThongBao.Name = "dtNgayThongBao";
            this.dtNgayThongBao.Size = new System.Drawing.Size(220, 20);
            this.dtNgayThongBao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgayThongBao.TabIndex = 2;
            this.dtNgayThongBao.Value = new System.DateTime(2013, 1, 18, 1, 29, 34, 0);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(211, 56);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(104, 23);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "Ngày thông báo: ";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(480, 171);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lvThongBao
            // 
            // 
            // 
            // 
            this.lvThongBao.Border.Class = "ListViewBorder";
            this.lvThongBao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvThongBao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maThongBao,
            this.tenThongBao,
            this.noiDungThongBao,
            this.ngayThongBao});
            this.lvThongBao.FullRowSelect = true;
            this.lvThongBao.GridLines = true;
            this.lvThongBao.Location = new System.Drawing.Point(12, 200);
            this.lvThongBao.MultiSelect = false;
            this.lvThongBao.Name = "lvThongBao";
            this.lvThongBao.Size = new System.Drawing.Size(550, 111);
            this.lvThongBao.TabIndex = 30;
            this.lvThongBao.UseCompatibleStateImageBehavior = false;
            this.lvThongBao.View = System.Windows.Forms.View.Details;
            this.lvThongBao.DoubleClick += new System.EventHandler(this.lvThongBao_DoubleClick);
            // 
            // maThongBao
            // 
            this.maThongBao.Text = "Mã TB";
            this.maThongBao.Width = 50;
            // 
            // tenThongBao
            // 
            this.tenThongBao.Text = "Tên thông báo";
            this.tenThongBao.Width = 130;
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
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(34, 171);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 23);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Danh sách thông báo: ";
            // 
            // frmLapThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 312);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.lvThongBao);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dtNgayThongBao);
            this.Controls.Add(this.tbxNoiDungThongBao);
            this.Controls.Add(this.tbxTenThongBao);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "frmLapThongBao";
            this.Text = "Lập thông báo";
            this.Load += new System.EventHandler(this.frmLapThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxTenThongBao;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxNoiDungThongBao;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayThongBao;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.ListViewEx lvThongBao;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ColumnHeader tenThongBao;
        private System.Windows.Forms.ColumnHeader noiDungThongBao;
        private System.Windows.Forms.ColumnHeader ngayThongBao;
        private System.Windows.Forms.ColumnHeader maThongBao;
    }
}