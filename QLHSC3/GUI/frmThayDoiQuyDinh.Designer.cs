namespace QLHSC3.GUI
{
    partial class frmThayDoiQuyDinh
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
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnThoatThem = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuThem = new DevComponents.DotNetBar.ButtonX();
            this.txtNoiDungQD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTenQD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.lbQDCu2 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.combQuyDinhXoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThoatXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.lbQuyDinhCu = new DevComponents.DotNetBar.LabelX();
            this.combQuyDinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnThoatSua = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuSua = new DevComponents.DotNetBar.ButtonX();
            this.txtNoiDungQDMoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 203);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.btnThoatThem);
            this.tabControlPanel1.Controls.Add(this.btnLuuThem);
            this.tabControlPanel1.Controls.Add(this.txtNoiDungQD);
            this.tabControlPanel1.Controls.Add(this.labelX3);
            this.tabControlPanel1.Controls.Add(this.txtTenQD);
            this.tabControlPanel1.Controls.Add(this.labelX4);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(579, 177);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            this.tabControlPanel1.Click += new System.EventHandler(this.tabControlPanel1_Click);
            // 
            // btnThoatThem
            // 
            this.btnThoatThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatThem.Location = new System.Drawing.Point(233, 125);
            this.btnThoatThem.Name = "btnThoatThem";
            this.btnThoatThem.Size = new System.Drawing.Size(75, 23);
            this.btnThoatThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoatThem.TabIndex = 10;
            this.btnThoatThem.Text = "Thoát";
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuThem.Location = new System.Drawing.Point(124, 125);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Size = new System.Drawing.Size(75, 23);
            this.btnLuuThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuThem.TabIndex = 9;
            this.btnLuuThem.Text = "Lưu";
            this.btnLuuThem.Click += new System.EventHandler(this.btnLuuThem_Click_1);
            // 
            // txtNoiDungQD
            // 
            // 
            // 
            // 
            this.txtNoiDungQD.Border.Class = "TextBoxBorder";
            this.txtNoiDungQD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNoiDungQD.Location = new System.Drawing.Point(124, 78);
            this.txtNoiDungQD.Name = "txtNoiDungQD";
            this.txtNoiDungQD.Size = new System.Drawing.Size(248, 20);
            this.txtNoiDungQD.TabIndex = 8;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(23, 80);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(107, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Nội dung quy định:";
            // 
            // txtTenQD
            // 
            // 
            // 
            // 
            this.txtTenQD.Border.Class = "TextBoxBorder";
            this.txtTenQD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenQD.Location = new System.Drawing.Point(124, 52);
            this.txtTenQD.Name = "txtTenQD";
            this.txtTenQD.Size = new System.Drawing.Size(248, 20);
            this.txtTenQD.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(23, 52);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Tên quy định:";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Thêm Quy Định";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.lbQDCu2);
            this.tabControlPanel3.Controls.Add(this.labelX8);
            this.tabControlPanel3.Controls.Add(this.combQuyDinhXoa);
            this.tabControlPanel3.Controls.Add(this.btnThoatXoa);
            this.tabControlPanel3.Controls.Add(this.btnXoa);
            this.tabControlPanel3.Controls.Add(this.labelX10);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(579, 177);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // lbQDCu2
            // 
            this.lbQDCu2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbQDCu2.BackgroundStyle.Class = "";
            this.lbQDCu2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbQDCu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQDCu2.Location = new System.Drawing.Point(144, 57);
            this.lbQDCu2.Name = "lbQDCu2";
            this.lbQDCu2.Size = new System.Drawing.Size(224, 23);
            this.lbQDCu2.TabIndex = 22;
            this.lbQDCu2.Text = "Nội dung quy định cũ: ";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(17, 57);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(121, 23);
            this.labelX8.TabIndex = 21;
            this.labelX8.Text = "Nội dung quy định cũ: ";
            // 
            // combQuyDinhXoa
            // 
            this.combQuyDinhXoa.DisplayMember = "Text";
            this.combQuyDinhXoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQuyDinhXoa.FormattingEnabled = true;
            this.combQuyDinhXoa.ItemHeight = 14;
            this.combQuyDinhXoa.Location = new System.Drawing.Point(138, 25);
            this.combQuyDinhXoa.Name = "combQuyDinhXoa";
            this.combQuyDinhXoa.Size = new System.Drawing.Size(230, 20);
            this.combQuyDinhXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.combQuyDinhXoa.TabIndex = 18;
            this.combQuyDinhXoa.SelectedIndexChanged += new System.EventHandler(this.combQuyDinhXoa_SelectedIndexChanged);
            // 
            // btnThoatXoa
            // 
            this.btnThoatXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatXoa.Location = new System.Drawing.Point(240, 96);
            this.btnThoatXoa.Name = "btnThoatXoa";
            this.btnThoatXoa.Size = new System.Drawing.Size(75, 23);
            this.btnThoatXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoatXoa.TabIndex = 17;
            this.btnThoatXoa.Text = "Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(138, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(18, 22);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(141, 23);
            this.labelX10.TabIndex = 12;
            this.labelX10.Text = "Quy định muốn xóa:";
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Xóa Quy Định";
            this.tabItem3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabItem3_MouseDown);
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.lbQuyDinhCu);
            this.tabControlPanel2.Controls.Add(this.combQuyDinh);
            this.tabControlPanel2.Controls.Add(this.labelX7);
            this.tabControlPanel2.Controls.Add(this.btnThoatSua);
            this.tabControlPanel2.Controls.Add(this.btnLuuSua);
            this.tabControlPanel2.Controls.Add(this.txtNoiDungQDMoi);
            this.tabControlPanel2.Controls.Add(this.labelX5);
            this.tabControlPanel2.Controls.Add(this.labelX6);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(579, 177);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // lbQuyDinhCu
            // 
            this.lbQuyDinhCu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbQuyDinhCu.BackgroundStyle.Class = "";
            this.lbQuyDinhCu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbQuyDinhCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuyDinhCu.Location = new System.Drawing.Point(153, 53);
            this.lbQuyDinhCu.Name = "lbQuyDinhCu";
            this.lbQuyDinhCu.Size = new System.Drawing.Size(224, 23);
            this.lbQuyDinhCu.TabIndex = 20;
            this.lbQuyDinhCu.Text = "Nội dung quy định cũ: ";
            // 
            // combQuyDinh
            // 
            this.combQuyDinh.DisplayMember = "Text";
            this.combQuyDinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQuyDinh.FormattingEnabled = true;
            this.combQuyDinh.ItemHeight = 14;
            this.combQuyDinh.Location = new System.Drawing.Point(153, 27);
            this.combQuyDinh.Name = "combQuyDinh";
            this.combQuyDinh.Size = new System.Drawing.Size(224, 20);
            this.combQuyDinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.combQuyDinh.TabIndex = 19;
            this.combQuyDinh.SelectedIndexChanged += new System.EventHandler(this.combQuyDinh_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(26, 53);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(121, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Nội dung quy định cũ: ";
            // 
            // btnThoatSua
            // 
            this.btnThoatSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatSua.Location = new System.Drawing.Point(256, 123);
            this.btnThoatSua.Name = "btnThoatSua";
            this.btnThoatSua.Size = new System.Drawing.Size(75, 23);
            this.btnThoatSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoatSua.TabIndex = 11;
            this.btnThoatSua.Text = "Thoát";
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuSua.Location = new System.Drawing.Point(153, 123);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuSua.TabIndex = 10;
            this.btnLuuSua.Text = "Lưu";
            this.btnLuuSua.Click += new System.EventHandler(this.btnLuuSua_Click);
            // 
            // txtNoiDungQDMoi
            // 
            // 
            // 
            // 
            this.txtNoiDungQDMoi.Border.Class = "TextBoxBorder";
            this.txtNoiDungQDMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNoiDungQDMoi.Location = new System.Drawing.Point(153, 85);
            this.txtNoiDungQDMoi.Name = "txtNoiDungQDMoi";
            this.txtNoiDungQDMoi.Size = new System.Drawing.Size(224, 20);
            this.txtNoiDungQDMoi.TabIndex = 9;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(26, 82);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(133, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Nội dung quy định mới:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(26, 24);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(121, 23);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "Quy định cần thay đổi:";
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Sửa Quy Định";
            this.tabItem2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabItem2_MouseDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(129, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(168, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 347);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "frmThayDoiQuyDinh";
            this.Load += new System.EventHandler(this.frmThayDoiQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenQD;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnThoatSua;
        private DevComponents.DotNetBar.ButtonX btnLuuSua;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNoiDungQDMoi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnThoatXoa;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combQuyDinhXoa;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbQuyDinhCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combQuyDinh;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnThoatThem;
        private DevComponents.DotNetBar.ButtonX btnLuuThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNoiDungQD;
        private DevComponents.DotNetBar.LabelX lbQDCu2;
        private DevComponents.DotNetBar.LabelX labelX8;
    }
}