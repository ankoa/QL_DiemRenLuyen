﻿namespace ql_diemrenluyen.GUI.USER
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DashboardContainer = new TableLayoutPanel();
            studentContainer = new TableLayoutPanel();
            classInfoContainer = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            panel4 = new Panel();
            dataGridView3 = new DataGridView();
            tableLayoutPanel9 = new TableLayoutPanel();
            lbCoVan = new Label();
            lbKhoas = new Label();
            lbKhoa = new Label();
            lbLop = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            studentInfoContainer = new TableLayoutPanel();
            studentInfoTitleContainer = new TableLayoutPanel();
            lbStudentInfo = new Label();
            studentInfoContent = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbEmail = new Label();
            lbGioiTinh = new Label();
            lbNgaySinh = new Label();
            lbHovaTen = new Label();
            lbMaSV = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            avtContainer = new TableLayoutPanel();
            pictureStudentAvt = new PictureBox();
            thongTinDrlContainer = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label8 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label7 = new Label();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label9 = new Label();
            panel5 = new Panel();
            dataGridView4 = new DataGridView();
            DashboardContainer.SuspendLayout();
            studentContainer.SuspendLayout();
            classInfoContainer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            studentInfoContainer.SuspendLayout();
            studentInfoTitleContainer.SuspendLayout();
            studentInfoContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            avtContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureStudentAvt).BeginInit();
            thongTinDrlContainer.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // DashboardContainer
            // 
            DashboardContainer.ColumnCount = 2;
            DashboardContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            DashboardContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            DashboardContainer.Controls.Add(studentContainer, 0, 0);
            DashboardContainer.Controls.Add(thongTinDrlContainer, 1, 0);
            DashboardContainer.Dock = DockStyle.Fill;
            DashboardContainer.Location = new Point(0, 0);
            DashboardContainer.Margin = new Padding(11, 13, 11, 13);
            DashboardContainer.Name = "DashboardContainer";
            DashboardContainer.Padding = new Padding(11, 13, 11, 13);
            DashboardContainer.RowCount = 1;
            DashboardContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DashboardContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DashboardContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DashboardContainer.Size = new Size(1322, 959);
            DashboardContainer.TabIndex = 0;
            DashboardContainer.Paint += DashboardContainer_Paint;
            // 
            // studentContainer
            // 
            studentContainer.BackColor = Color.White;
            studentContainer.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            studentContainer.ColumnCount = 1;
            studentContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            studentContainer.Controls.Add(classInfoContainer, 0, 1);
            studentContainer.Controls.Add(studentInfoContainer, 0, 0);
            studentContainer.Dock = DockStyle.Fill;
            studentContainer.Location = new Point(22, 26);
            studentContainer.Margin = new Padding(11, 13, 11, 13);
            studentContainer.Name = "studentContainer";
            studentContainer.RowCount = 2;
            studentContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 61.2211227F));
            studentContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 38.7788773F));
            studentContainer.Size = new Size(498, 907);
            studentContainer.TabIndex = 0;
            // 
            // classInfoContainer
            // 
            classInfoContainer.BackColor = Color.White;
            classInfoContainer.ColumnCount = 1;
            classInfoContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            classInfoContainer.Controls.Add(tableLayoutPanel2, 0, 0);
            classInfoContainer.Controls.Add(tableLayoutPanel10, 0, 1);
            classInfoContainer.Dock = DockStyle.Fill;
            classInfoContainer.Location = new Point(5, 560);
            classInfoContainer.Margin = new Padding(3, 5, 3, 4);
            classInfoContainer.Name = "classInfoContainer";
            classInfoContainer.RowCount = 2;
            classInfoContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            classInfoContainer.RowStyles.Add(new RowStyle());
            classInfoContainer.Size = new Size(488, 341);
            classInfoContainer.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.5655746F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.4344254F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(488, 40);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 40);
            label1.TabIndex = 0;
            label1.Text = "Thông tin lớp học";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(panel4, 0, 1);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 44);
            tableLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(482, 293);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(dataGridView3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 146);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 0, 5, 20);
            panel4.Size = new Size(482, 147);
            panel4.TabIndex = 3;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle37.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle37.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle37.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            dataGridView3.ColumnHeadersHeight = 35;
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = SystemColors.Window;
            dataGridViewCellStyle38.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle38.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = Color.White;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle38;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.LightGray;
            dataGridView3.Location = new Point(5, 0);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = SystemColors.Control;
            dataGridViewCellStyle39.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 25;
            dataGridView3.RowTemplate.DividerHeight = 1;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(472, 127);
            dataGridView3.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.7835F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.2165F));
            tableLayoutPanel9.Controls.Add(lbCoVan, 1, 3);
            tableLayoutPanel9.Controls.Add(lbKhoas, 1, 2);
            tableLayoutPanel9.Controls.Add(lbKhoa, 1, 1);
            tableLayoutPanel9.Controls.Add(lbLop, 1, 0);
            tableLayoutPanel9.Controls.Add(label15, 0, 0);
            tableLayoutPanel9.Controls.Add(label16, 0, 1);
            tableLayoutPanel9.Controls.Add(label17, 0, 2);
            tableLayoutPanel9.Controls.Add(label18, 0, 3);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 4);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.Padding = new Padding(0, 0, 0, 11);
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel9.Size = new Size(476, 138);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // lbCoVan
            // 
            lbCoVan.AutoSize = true;
            lbCoVan.Dock = DockStyle.Fill;
            lbCoVan.Font = new Font("Segoe UI", 10F);
            lbCoVan.Location = new Point(159, 93);
            lbCoVan.Name = "lbCoVan";
            lbCoVan.Size = new Size(314, 34);
            lbCoVan.TabIndex = 8;
            lbCoVan.Text = "label10";
            lbCoVan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbKhoas
            // 
            lbKhoas.AutoSize = true;
            lbKhoas.Dock = DockStyle.Fill;
            lbKhoas.Font = new Font("Segoe UI", 10F);
            lbKhoas.Location = new Point(159, 62);
            lbKhoas.Name = "lbKhoas";
            lbKhoas.Size = new Size(314, 31);
            lbKhoas.TabIndex = 7;
            lbKhoas.Text = "label9";
            lbKhoas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbKhoa
            // 
            lbKhoa.AutoSize = true;
            lbKhoa.Dock = DockStyle.Fill;
            lbKhoa.Font = new Font("Segoe UI", 10F);
            lbKhoa.Location = new Point(159, 31);
            lbKhoa.Name = "lbKhoa";
            lbKhoa.Size = new Size(314, 31);
            lbKhoa.TabIndex = 6;
            lbKhoa.Text = "label8";
            lbKhoa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Dock = DockStyle.Fill;
            lbLop.Font = new Font("Segoe UI", 10F);
            lbLop.Location = new Point(159, 0);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(314, 31);
            lbLop.TabIndex = 5;
            lbLop.Text = "label7";
            lbLop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(150, 31);
            label15.TabIndex = 0;
            label15.Text = "Lớp: ";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(3, 31);
            label16.Name = "label16";
            label16.Size = new Size(150, 31);
            label16.TabIndex = 1;
            label16.Text = "Khoa: ";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(3, 62);
            label17.Name = "label17";
            label17.Size = new Size(150, 31);
            label17.TabIndex = 2;
            label17.Text = "Khóa: ";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(3, 93);
            label18.Name = "label18";
            label18.Size = new Size(150, 34);
            label18.TabIndex = 3;
            label18.Text = "Cố vấn học tập:";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studentInfoContainer
            // 
            studentInfoContainer.BackColor = Color.White;
            studentInfoContainer.ColumnCount = 1;
            studentInfoContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            studentInfoContainer.Controls.Add(studentInfoTitleContainer, 0, 0);
            studentInfoContainer.Controls.Add(studentInfoContent, 0, 1);
            studentInfoContainer.Dock = DockStyle.Fill;
            studentInfoContainer.Location = new Point(5, 6);
            studentInfoContainer.Margin = new Padding(3, 4, 3, 5);
            studentInfoContainer.Name = "studentInfoContainer";
            studentInfoContainer.RowCount = 2;
            studentInfoContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            studentInfoContainer.RowStyles.Add(new RowStyle());
            studentInfoContainer.Size = new Size(488, 542);
            studentInfoContainer.TabIndex = 0;
            // 
            // studentInfoTitleContainer
            // 
            studentInfoTitleContainer.BackColor = SystemColors.ButtonFace;
            studentInfoTitleContainer.ColumnCount = 2;
            studentInfoTitleContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3114738F));
            studentInfoTitleContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.6885262F));
            studentInfoTitleContainer.Controls.Add(lbStudentInfo, 0, 0);
            studentInfoTitleContainer.Dock = DockStyle.Fill;
            studentInfoTitleContainer.Location = new Point(0, 0);
            studentInfoTitleContainer.Margin = new Padding(0);
            studentInfoTitleContainer.Name = "studentInfoTitleContainer";
            studentInfoTitleContainer.RowCount = 1;
            studentInfoTitleContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            studentInfoTitleContainer.Size = new Size(488, 40);
            studentInfoTitleContainer.TabIndex = 0;
            // 
            // lbStudentInfo
            // 
            lbStudentInfo.AutoSize = true;
            lbStudentInfo.Dock = DockStyle.Fill;
            lbStudentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStudentInfo.ForeColor = SystemColors.HotTrack;
            lbStudentInfo.Location = new Point(3, 0);
            lbStudentInfo.Name = "lbStudentInfo";
            lbStudentInfo.Size = new Size(220, 40);
            lbStudentInfo.TabIndex = 0;
            lbStudentInfo.Text = "Thông tin sinh viên";
            lbStudentInfo.TextAlign = ContentAlignment.MiddleLeft;
            lbStudentInfo.Click += label1_Click;
            // 
            // studentInfoContent
            // 
            studentInfoContent.ColumnCount = 2;
            studentInfoContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.52585F));
            studentInfoContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.4741516F));
            studentInfoContent.Controls.Add(tableLayoutPanel1, 0, 0);
            studentInfoContent.Controls.Add(avtContainer, 1, 0);
            studentInfoContent.Dock = DockStyle.Fill;
            studentInfoContent.Location = new Point(17, 44);
            studentInfoContent.Margin = new Padding(17, 4, 3, 4);
            studentInfoContent.Name = "studentInfoContent";
            studentInfoContent.RowCount = 1;
            studentInfoContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            studentInfoContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            studentInfoContent.Size = new Size(468, 494);
            studentInfoContent.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.7835045F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.21649F));
            tableLayoutPanel1.Controls.Add(lbEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(lbGioiTinh, 1, 3);
            tableLayoutPanel1.Controls.Add(lbNgaySinh, 1, 2);
            tableLayoutPanel1.Controls.Add(lbHovaTen, 1, 1);
            tableLayoutPanel1.Controls.Add(lbMaSV, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 0, 11);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(333, 486);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Dock = DockStyle.Fill;
            lbEmail.Font = new Font("Segoe UI", 10F);
            lbEmail.Location = new Point(112, 380);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(218, 95);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "label11";
            lbEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Dock = DockStyle.Fill;
            lbGioiTinh.Font = new Font("Segoe UI", 10F);
            lbGioiTinh.Location = new Point(112, 285);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(218, 95);
            lbGioiTinh.TabIndex = 8;
            lbGioiTinh.Text = "label10";
            lbGioiTinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Dock = DockStyle.Fill;
            lbNgaySinh.Font = new Font("Segoe UI", 10F);
            lbNgaySinh.Location = new Point(112, 190);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(218, 95);
            lbNgaySinh.TabIndex = 7;
            lbNgaySinh.Text = "label9";
            lbNgaySinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbHovaTen
            // 
            lbHovaTen.AutoSize = true;
            lbHovaTen.Dock = DockStyle.Fill;
            lbHovaTen.Font = new Font("Segoe UI", 10F);
            lbHovaTen.Location = new Point(112, 95);
            lbHovaTen.Name = "lbHovaTen";
            lbHovaTen.Size = new Size(218, 95);
            lbHovaTen.TabIndex = 6;
            lbHovaTen.Text = "label8";
            lbHovaTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMaSV
            // 
            lbMaSV.AutoSize = true;
            lbMaSV.Dock = DockStyle.Fill;
            lbMaSV.Font = new Font("Segoe UI", 10F);
            lbMaSV.Location = new Point(112, 0);
            lbMaSV.Name = "lbMaSV";
            lbMaSV.Size = new Size(218, 95);
            lbMaSV.TabIndex = 5;
            lbMaSV.Text = "label7";
            lbMaSV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 95);
            label2.TabIndex = 0;
            label2.Text = "Mã SV:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(3, 95);
            label3.Name = "label3";
            label3.Size = new Size(103, 95);
            label3.TabIndex = 1;
            label3.Text = "Họ và Tên:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(3, 190);
            label4.Name = "label4";
            label4.Size = new Size(103, 95);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(3, 285);
            label5.Name = "label5";
            label5.Size = new Size(103, 95);
            label5.TabIndex = 3;
            label5.Text = "Giới tính:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(3, 380);
            label6.Name = "label6";
            label6.Size = new Size(103, 95);
            label6.TabIndex = 4;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // avtContainer
            // 
            avtContainer.ColumnCount = 1;
            avtContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            avtContainer.Controls.Add(pictureStudentAvt, 0, 1);
            avtContainer.Dock = DockStyle.Fill;
            avtContainer.Location = new Point(342, 4);
            avtContainer.Margin = new Padding(3, 4, 3, 4);
            avtContainer.Name = "avtContainer";
            avtContainer.RowCount = 3;
            avtContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6610985F));
            avtContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 36.7541771F));
            avtContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 45.5847244F));
            avtContainer.Size = new Size(123, 486);
            avtContainer.TabIndex = 2;
            avtContainer.Paint += tableLayoutPanel3_Paint;
            // 
            // pictureStudentAvt
            // 
            pictureStudentAvt.BackgroundImage = Properties.Resources._2_1;
            pictureStudentAvt.BackgroundImageLayout = ImageLayout.Zoom;
            pictureStudentAvt.Dock = DockStyle.Fill;
            pictureStudentAvt.Location = new Point(3, 89);
            pictureStudentAvt.Margin = new Padding(3, 4, 3, 4);
            pictureStudentAvt.Name = "pictureStudentAvt";
            pictureStudentAvt.Size = new Size(117, 170);
            pictureStudentAvt.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudentAvt.TabIndex = 0;
            pictureStudentAvt.TabStop = false;
            // 
            // thongTinDrlContainer
            // 
            thongTinDrlContainer.BackColor = Color.White;
            thongTinDrlContainer.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            thongTinDrlContainer.ColumnCount = 1;
            thongTinDrlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            thongTinDrlContainer.Controls.Add(tableLayoutPanel6, 0, 2);
            thongTinDrlContainer.Controls.Add(tableLayoutPanel4, 0, 1);
            thongTinDrlContainer.Controls.Add(panel1, 0, 0);
            thongTinDrlContainer.Dock = DockStyle.Fill;
            thongTinDrlContainer.Location = new Point(542, 26);
            thongTinDrlContainer.Margin = new Padding(11, 13, 11, 13);
            thongTinDrlContainer.Name = "thongTinDrlContainer";
            thongTinDrlContainer.RowCount = 3;
            thongTinDrlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            thongTinDrlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            thongTinDrlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            thongTinDrlContainer.Size = new Size(758, 907);
            thongTinDrlContainer.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(panel2, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(5, 458);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(748, 443);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.0240974F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9759026F));
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(748, 40);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(338, 40);
            label8.TabIndex = 0;
            label8.Text = "Điểm rèn luyện các kì";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5, 0, 5, 20);
            panel2.Size = new Size(748, 463);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle40.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle40.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = SystemColors.Window;
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle41.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = Color.White;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle41;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(5, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = SystemColors.Control;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle42.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.RowTemplate.DividerHeight = 1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(738, 443);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(panel3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 187);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(748, 261);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4337349F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5662651F));
            tableLayoutPanel5.Controls.Add(label7, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(748, 40);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(356, 40);
            label7.TabIndex = 0;
            label7.Text = "Đợt chấm điểm của bạn";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(dataGridView2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5, 0, 5, 20);
            panel3.Size = new Size(748, 256);
            panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle43.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle43.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = SystemColors.Window;
            dataGridViewCellStyle44.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle44.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = Color.White;
            dataGridViewCellStyle44.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle44;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(5, 0);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = SystemColors.Control;
            dataGridViewCellStyle45.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle45.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle45.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.RowTemplate.DividerHeight = 1;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(738, 236);
            dataGridView2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 6);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 171);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel3.Controls.Add(panel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(748, 171);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.81042F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.18958F));
            tableLayoutPanel8.Controls.Add(label9, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(748, 40);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(299, 40);
            label9.TabIndex = 0;
            label9.Text = "Nhắc nhở mới";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(dataGridView4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 40);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5, 0, 5, 20);
            panel5.Size = new Size(748, 155);
            panel5.TabIndex = 2;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle46.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle46.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle46.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            dataGridView4.ColumnHeadersHeight = 35;
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = SystemColors.Window;
            dataGridViewCellStyle47.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle47.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle47.SelectionForeColor = Color.Red;
            dataGridViewCellStyle47.WrapMode = DataGridViewTriState.False;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle47;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.GridColor = Color.LightGray;
            dataGridView4.Location = new Point(5, 0);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.MultiSelect = false;
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = SystemColors.Control;
            dataGridViewCellStyle48.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle48.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
            dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 25;
            dataGridView4.RowTemplate.DividerHeight = 1;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(738, 135);
            dataGridView4.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1322, 959);
            Controls.Add(DashboardContainer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            DashboardContainer.ResumeLayout(false);
            studentContainer.ResumeLayout(false);
            classInfoContainer.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            studentInfoContainer.ResumeLayout(false);
            studentInfoTitleContainer.ResumeLayout(false);
            studentInfoTitleContainer.PerformLayout();
            studentInfoContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            avtContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureStudentAvt).EndInit();
            thongTinDrlContainer.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel DashboardContainer;
        private TableLayoutPanel studentContainer;
        private TableLayoutPanel studentInfoContainer;
        private TableLayoutPanel studentInfoTitleContainer;
        private Label lbStudentInfo;
        private TableLayoutPanel classInfoContainer;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel studentInfoContent;
        private PictureBox pictureStudentAvt;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbEmail;
        private Label lbGioiTinh;
        private Label lbNgaySinh;
        private Label lbHovaTen;
        private Label lbMaSV;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel avtContainer;
        private TableLayoutPanel thongTinDrlContainer;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label7;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label9;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lbCoVan;
        private Label lbKhoas;
        private Label lbKhoa;
        private Label lbLop;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel10;
        private Panel panel4;
        private DataGridView dataGridView3;
        private Panel panel5;
        private DataGridView dataGridView4;
    }
}