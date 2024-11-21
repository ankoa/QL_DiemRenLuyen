﻿namespace ql_diemrenluyen.GUI.ADMIN.Account
{
    partial class AccountDetailsForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            lblId = new Label();
            txtId = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            lblRememberToken = new Label();
            txtRememberToken = new TextBox();
            lblCreatedAt = new Label();
            lblUpdatedAt = new Label();
            dtpUpdatedAt = new DateTimePicker();
            lblStatus = new Label();
            btnClose = new Button();
            btnEdit = new Button();
            label2 = new Label();
            dtpCreatedAt = new DateTimePicker();
            comboBox1 = new ComboBox();
            cmbRole = new ComboBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(58, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(184, 64);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(58, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLightLight;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(184, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.Location = new Point(58, 148);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(35, 15);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            // 
            // lblRememberToken
            // 
            lblRememberToken.AutoSize = true;
            lblRememberToken.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRememberToken.Location = new Point(58, 191);
            lblRememberToken.Name = "lblRememberToken";
            lblRememberToken.Size = new Size(110, 15);
            lblRememberToken.TabIndex = 6;
            lblRememberToken.Text = "Remember Token:";
            // 
            // txtRememberToken
            // 
            txtRememberToken.BackColor = SystemColors.ControlLightLight;
            txtRememberToken.BorderStyle = BorderStyle.FixedSingle;
            txtRememberToken.Location = new Point(184, 191);
            txtRememberToken.Name = "txtRememberToken";
            txtRememberToken.ReadOnly = true;
            txtRememberToken.Size = new Size(200, 23);
            txtRememberToken.TabIndex = 7;
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCreatedAt.Location = new Point(58, 238);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(70, 15);
            lblCreatedAt.TabIndex = 8;
            lblCreatedAt.Text = "Created At:";
            // 
            // lblUpdatedAt
            // 
            lblUpdatedAt.AutoSize = true;
            lblUpdatedAt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdatedAt.Location = new Point(58, 284);
            lblUpdatedAt.Name = "lblUpdatedAt";
            lblUpdatedAt.Size = new Size(74, 15);
            lblUpdatedAt.TabIndex = 10;
            lblUpdatedAt.Text = "Updated At:";
            // 
            // dtpUpdatedAt
            // 
            dtpUpdatedAt.Location = new Point(184, 284);
            dtpUpdatedAt.Name = "dtpUpdatedAt";
            dtpUpdatedAt.Size = new Size(200, 23);
            dtpUpdatedAt.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(58, 326);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(284, 386);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 14;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(174, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 7);
            label2.Name = "label2";
            label2.Size = new Size(215, 30);
            label2.TabIndex = 18;
            label2.Text = "Thông tin tài khoản";
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.Location = new Point(184, 238);
            dtpCreatedAt.Margin = new Padding(3, 2, 3, 2);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(200, 23);
            dtpCreatedAt.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            comboBox1.Location = new Point(184, 326);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 20;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(184, 148);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 23);
            cmbRole.TabIndex = 21;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(58, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(422, 490);
            Controls.Add(btnDelete);
            Controls.Add(cmbRole);
            Controls.Add(comboBox1);
            Controls.Add(dtpCreatedAt);
            Controls.Add(label2);
            Controls.Add(btnEdit);
            Controls.Add(btnClose);
            Controls.Add(lblStatus);
            Controls.Add(dtpUpdatedAt);
            Controls.Add(lblUpdatedAt);
            Controls.Add(lblCreatedAt);
            Controls.Add(txtRememberToken);
            Controls.Add(lblRememberToken);
            Controls.Add(lblRole);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label lblId;
        private TextBox txtId;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private Label lblRememberToken;
        private TextBox txtRememberToken;
        private Label lblCreatedAt;
        private Label lblUpdatedAt;
        private DateTimePicker dtpUpdatedAt;
        private Label lblStatus;
        private Button btnClose;
        private Button btnEdit;
        private Label label2;
        private DateTimePicker dtpCreatedAt;
        private ComboBox comboBox1;
        private ComboBox cmbRole;
        private Button btnDelete;
    }

}