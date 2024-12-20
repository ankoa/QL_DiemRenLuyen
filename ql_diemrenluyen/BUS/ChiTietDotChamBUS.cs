﻿using ql_diemrenluyen.DAO;
using ql_diemrenluyen.DTO;

namespace ql_diemrenluyen.BUS
{
    public class ChiTietDotChamBUS
    {
        // Lấy tất cả chi tiết đợt chấm
        public static List<ChiTietDotChamDTO> GetAllChiTietDotCham()
        {
            try
            {
                return ChiTietDotChamDAO.GetAllChiTietDotCham();
            }
            catch (Exception ex)
            {
                // Log lỗi và trả về danh sách rỗng
                Console.WriteLine("Lỗi khi lấy tất cả chi tiết đợt chấm: " + ex.Message);
                return new List<ChiTietDotChamDTO>();
            }
        }

        // Thêm chi tiết đợt chấm mới
        public static bool AddChiTietDotCham(ChiTietDotChamDTO chiTietDotCham)
        {

            return ChiTietDotChamDAO.AddChiTietDotCham(chiTietDotCham);

        }

        // Cập nhật chi tiết đợt chấm
        public static bool UpdateChiTietDotCham(ChiTietDotChamDTO chiTietDotCham)
        {
            try
            {
                // Thực hiện kiểm tra logic trước khi cập nhật
                if (chiTietDotCham.Diem < 0 || chiTietDotCham.Diem > 100)
                {
                    throw new ArgumentException("Điểm phải nằm trong khoảng từ 0 đến 100.");
                }

                return ChiTietDotChamDAO.UpdateChiTietDotCham(chiTietDotCham);
            }
            catch (Exception ex)
            {
                // Log lỗi và trả về false
                Console.WriteLine("Lỗi khi cập nhật chi tiết đợt chấm: " + ex.Message);
                return false;
            }
        }

        // Xóa chi tiết đợt chấm (cập nhật status)
        public static bool DeleteChiTietDotCham(long id)
        {
            try
            {
                return ChiTietDotChamDAO.DeleteChiTietDotCham(id);
            }
            catch (Exception ex)
            {
                // Log lỗi và trả về false
                Console.WriteLine("Lỗi khi xóa chi tiết đợt chấm: " + ex.Message);
                return false;
            }
        }
        //public static bool IsChiTietDotChamExist(long thongTinDotChamDiemId)
        //{
        //    // Gọi phương thức DAO để kiểm tra sự tồn tại
        //    return ChiTietDotChamDAO.IsChiTietDotChamExist(thongTinDotChamDiemId);
        //}
        public static bool IsChiTietDotChamExist(long thongTinDotChamDiemId)
        {
            // Lấy toàn bộ danh sách chi tiết đợt chấm
            List<ChiTietDotChamDTO> chiTietDotChamList = ChiTietDotChamBUS.GetAllChiTietDotCham();

            // Kiểm tra nếu có bản ghi nào có thongTinDotChamDiemId phù hợp và status = 1
            return chiTietDotChamList.Any(chiTiet =>
                chiTiet.ThongTinDotChamDiemId == thongTinDotChamDiemId && chiTiet.Status == 1);
        }
        public static List<ChiTietDotChamDTO> GetListChiTietDotChamByThongTinDotChamId(long thongTinDotChamDiemId)
        {
            return ChiTietDotChamDAO.GetListChiTietDotChamByThongTinDotChamId(thongTinDotChamDiemId);
        }

       
        public static int? GetDiem(long sinhVienID, long tieuChiDanhGiaID, int dotchamdiemID, long? coVanID = null, long? khoaID = null, int? final = null)
        {
            try
            {
                return ChiTietDotChamDAO.GetDiem(sinhVienID, tieuChiDanhGiaID, dotchamdiemID, coVanID, khoaID, final);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (log lỗi hoặc thông báo người dùng)
                Console.WriteLine("Lỗi khi lấy điểm: " + ex.Message);
                return null;
            }
        }

        // Lấy thông tin bằng chứng của sinh viên
        public static (string? ImageUrl, string? Mota) GetBangChung(long sinhVienID, long tieuChiDanhGiaID, int dotChamDiemID)
        {
            try
            {
                return ChiTietDotChamDAO.GetBangChung(sinhVienID, tieuChiDanhGiaID, dotChamDiemID);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (log lỗi hoặc thông báo người dùng)
                Console.WriteLine("Lỗi khi lấy bằng chứng: " + ex.Message);
                return (null, null);
            }
        }
    }
}

