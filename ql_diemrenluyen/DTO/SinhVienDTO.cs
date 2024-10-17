﻿namespace ql_diemrenluyen.DTO
{
    public class SinhVienDTO
    {
        private long id;
        private string name;
        private string maSv;
        private DateTime ngaySinh;  // Đổi thành DateTime
        private string email;
        private int gioiTinh;
        private long lopId;
        private int chucVu;
        private DateTime createdAt;  // Thêm thuộc tính createdAt
        private DateTime updatedAt;  // Thêm thuộc tính updatedAt

        // Constructor
        public SinhVienDTO() { }

        public SinhVienDTO(long id, string name, string maSv, DateTime ngaySinh, string email, int gioiTinh, long lopId, int chucVu, DateTime createdAt, DateTime updatedAt)
        {
            this.id = id;
            this.name = name;
            this.maSv = maSv;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.gioiTinh = gioiTinh;
            this.lopId = lopId;
            this.chucVu = chucVu;
            this.createdAt = createdAt;  // Gán giá trị
            this.updatedAt = updatedAt;  // Gán giá trị
        }

        // Getters và Setters
        public long Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string MaSv { get { return maSv; } set { maSv = value; } }
        public DateTime NgaySinh { get { return ngaySinh; } set { ngaySinh = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public long LopId { get { return lopId; } set { lopId = value; } }
        public int ChucVu { get { return chucVu; } set { chucVu = value; } }
        public DateTime CreatedAt { get { return createdAt; } set { createdAt = value; } }  // Getter và Setter cho createdAt
        public DateTime UpdatedAt { get { return updatedAt; } set { updatedAt = value; } }  // Getter và Setter cho updatedAt
    }
}
