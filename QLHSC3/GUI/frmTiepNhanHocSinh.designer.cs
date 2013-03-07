namespace QLHSC3
{
    partial class frmTiepNhanHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtgvHocSinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPThongTinHS = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtimeNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnKhongLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.tbxHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbDiaChi = new DevComponents.DotNetBar.LabelX();
            this.tbxDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbGioiTinh = new DevComponents.DotNetBar.LabelX();
            this.tbxEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbEmail = new DevComponents.DotNetBar.LabelX();
            this.lbHoTen = new DevComponents.DotNetBar.LabelX();
            this.rdioNu = new System.Windows.Forms.RadioButton();
            this.lbNgaySinh = new DevComponents.DotNetBar.LabelX();
            this.rdioNam = new System.Windows.Forms.RadioButton();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocSinh)).BeginInit();
            this.gPThongTinHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(227, 419);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(413, 419);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(317, 419);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtgvHocSinh);
            this.groupPanel1.Location = new System.Drawing.Point(2, 134);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(744, 279);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 15;
            this.groupPanel1.Text = "Danh Sách Học Sinh";
            // 
            // dtgvHocSinh
            // 
            this.dtgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HoTen,
            this.MaHocSinh,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.Email});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHocSinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvHocSinh.Location = new System.Drawing.Point(9, 3);
            this.dtgvHocSinh.MultiSelect = false;
            this.dtgvHocSinh.Name = "dtgvHocSinh";
            this.dtgvHocSinh.ReadOnly = true;
            this.dtgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHocSinh.Size = new System.Drawing.Size(726, 252);
            this.dtgvHocSinh.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "stt";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 30;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "hoTen";
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 130;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "maHocSinh";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "gioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 80;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "ngaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 80;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "diaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 130;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // gPThongTinHS
            // 
            this.gPThongTinHS.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPThongTinHS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gPThongTinHS.Controls.Add(this.dtimeNgaySinh);
            this.gPThongTinHS.Controls.Add(this.btnKhongLuu);
            this.gPThongTinHS.Controls.Add(this.btnLuu);
            this.gPThongTinHS.Controls.Add(this.tbxHoTen);
            this.gPThongTinHS.Controls.Add(this.lbDiaChi);
            this.gPThongTinHS.Controls.Add(this.tbxDiaChi);
            this.gPThongTinHS.Controls.Add(this.lbGioiTinh);
            this.gPThongTinHS.Controls.Add(this.tbxEmail);
            this.gPThongTinHS.Controls.Add(this.lbEmail);
            this.gPThongTinHS.Controls.Add(this.lbHoTen);
            this.gPThongTinHS.Controls.Add(this.rdioNu);
            this.gPThongTinHS.Controls.Add(this.lbNgaySinh);
            this.gPThongTinHS.Controls.Add(this.rdioNam);
            this.gPThongTinHS.Location = new System.Drawing.Point(2, 32);
            this.gPThongTinHS.Name = "gPThongTinHS";
            this.gPThongTinHS.Size = new System.Drawing.Size(744, 102);
            // 
            // 
            // 
            this.gPThongTinHS.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPThongTinHS.Style.BackColorGradientAngle = 90;
            this.gPThongTinHS.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPThongTinHS.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPThongTinHS.Style.BorderBottomWidth = 1;
            this.gPThongTinHS.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPThongTinHS.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPThongTinHS.Style.BorderLeftWidth = 1;
            this.gPThongTinHS.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPThongTinHS.Style.BorderRightWidth = 1;
            this.gPThongTinHS.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPThongTinHS.Style.BorderTopWidth = 1;
            this.gPThongTinHS.Style.Class = "";
            this.gPThongTinHS.Style.CornerDiameter = 4;
            this.gPThongTinHS.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPThongTinHS.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gPThongTinHS.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPThongTinHS.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPThongTinHS.StyleMouseDown.Class = "";
            this.gPThongTinHS.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPThongTinHS.StyleMouseOver.Class = "";
            this.gPThongTinHS.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPThongTinHS.TabIndex = 12;
            this.gPThongTinHS.Text = "Thông Tin Học Sinh";
            // 
            // dtimeNgaySinh
            // 
            // 
            // 
            // 
            this.dtimeNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtimeNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtimeNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtimeNgaySinh.ButtonDropDown.Visible = true;
            this.dtimeNgaySinh.Location = new System.Drawing.Point(86, 29);
            // 
            // 
            // 
            this.dtimeNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtimeNgaySinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtimeNgaySinh.MonthCalendar.BackgroundStyle.Class = "";
            this.dtimeNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtimeNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtimeNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtimeNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            this.dtimeNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtimeNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtimeNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtimeNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtimeNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtimeNgaySinh.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtimeNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtimeNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtimeNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtimeNgaySinh.Name = "dtimeNgaySinh";
            this.dtimeNgaySinh.Size = new System.Drawing.Size(188, 20);
            this.dtimeNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtimeNgaySinh.TabIndex = 4;
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKhongLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKhongLuu.Location = new System.Drawing.Point(592, 55);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(75, 23);
            this.btnKhongLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKhongLuu.TabIndex = 14;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(473, 55);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbxHoTen
            // 
            // 
            // 
            // 
            this.tbxHoTen.Border.Class = "TextBoxBorder";
            this.tbxHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxHoTen.Location = new System.Drawing.Point(86, 3);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(188, 20);
            this.tbxHoTen.TabIndex = 1;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbDiaChi.BackgroundStyle.Class = "";
            this.lbDiaChi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(280, 26);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(45, 23);
            this.lbDiaChi.TabIndex = 7;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // tbxDiaChi
            // 
            // 
            // 
            // 
            this.tbxDiaChi.Border.Class = "TextBoxBorder";
            this.tbxDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxDiaChi.Location = new System.Drawing.Point(329, 29);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(219, 20);
            this.tbxDiaChi.TabIndex = 5;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbGioiTinh.BackgroundStyle.Class = "";
            this.lbGioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(280, 3);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(63, 23);
            this.lbGioiTinh.TabIndex = 11;
            this.lbGioiTinh.Text = "Giới Tính:";
            // 
            // tbxEmail
            // 
            // 
            // 
            // 
            this.tbxEmail.Border.Class = "TextBoxBorder";
            this.tbxEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxEmail.Location = new System.Drawing.Point(592, 26);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(133, 20);
            this.tbxEmail.TabIndex = 6;
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbEmail.BackgroundStyle.Class = "";
            this.lbEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(554, 26);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 23);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbHoTen.BackgroundStyle.Class = "";
            this.lbHoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(19, 3);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(61, 23);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ và Tên";
            // 
            // rdioNu
            // 
            this.rdioNu.AutoSize = true;
            this.rdioNu.BackColor = System.Drawing.Color.Transparent;
            this.rdioNu.Location = new System.Drawing.Point(412, 6);
            this.rdioNu.Name = "rdioNu";
            this.rdioNu.Size = new System.Drawing.Size(39, 17);
            this.rdioNu.TabIndex = 3;
            this.rdioNu.Text = "Nữ";
            this.rdioNu.UseVisualStyleBackColor = false;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbNgaySinh.BackgroundStyle.Class = "";
            this.lbNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(19, 26);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(61, 23);
            this.lbNgaySinh.TabIndex = 5;
            this.lbNgaySinh.Text = "Ngày Sinh";
            // 
            // rdioNam
            // 
            this.rdioNam.AutoSize = true;
            this.rdioNam.BackColor = System.Drawing.Color.Transparent;
            this.rdioNam.Checked = true;
            this.rdioNam.Location = new System.Drawing.Point(359, 6);
            this.rdioNam.Name = "rdioNam";
            this.rdioNam.Size = new System.Drawing.Size(47, 17);
            this.rdioNam.TabIndex = 2;
            this.rdioNam.TabStop = true;
            this.rdioNam.Text = "Nam";
            this.rdioNam.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Location = new System.Drawing.Point(671, 419);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(290, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(180, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Tiếp Nhận Học Sinh";
            // 
            // frmTiepNhanHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 447);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gPThongTinHS);
            this.DoubleBuffered = true;
            this.Name = "frmTiepNhanHocSinh";
            this.Text = "Tiếp Nhận Học Sinh";
            this.Load += new System.EventHandler(this.frmTiepNhanHocSinh_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocSinh)).EndInit();
            this.gPThongTinHS.ResumeLayout(false);
            this.gPThongTinHS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtimeNgaySinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxEmail;
        private DevComponents.DotNetBar.LabelX lbEmail;
        private DevComponents.DotNetBar.LabelX lbDiaChi;
        private DevComponents.DotNetBar.LabelX lbNgaySinh;
        private System.Windows.Forms.RadioButton rdioNu;
        private System.Windows.Forms.RadioButton rdioNam;
        private DevComponents.DotNetBar.LabelX lbHoTen;
        private DevComponents.DotNetBar.LabelX lbGioiTinh;
        private DevComponents.DotNetBar.Controls.GroupPanel gPThongTinHS;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxHoTen;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnKhongLuu;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtimeNgaySinh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

