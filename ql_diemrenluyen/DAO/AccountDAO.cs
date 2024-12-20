using MySql.Data.MySqlClient;
using ql_diemrenluyen.DTO;
using System.Data;

namespace ql_diemrenluyen.DAO
{
    public class AccountDAO
    {
        //List<AccountDTO> accounts = new List<AccountDTO>();
        //string sql = "SELECT * FORM account";
        //List<List<object>> result = DBConnection.ExecuteReader(sql);
        //    foreach (var row in result)
        //    {
        //        AccountDTO account = new AccountDTO();
        //account.Id = Convert.ToInt32(row[0]);
        //        account.UpdatedAt = Convert.ToDateTime(row[1]);
        //        account.Password = Convert.ToString(row[2]);
        //    }

        //    return accounts;
        // Lấy tất cả tài khoản
        public static List<AccountDTO> GetAllAccounts()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            string sql = "SELECT * FROM account"; 

            List<List<object>> result = DBConnection.ExecuteReader(sql);

            foreach (var row in result)
            {
                AccountDTO account = new AccountDTO
                {
                    Id = Convert.ToInt64(row[0]), // id
                    Role = Convert.ToInt32(row[1]), // vaitro: Chuyển thành int
                    Password = Convert.ToString(row[2]), // password
                    RememberToken = row[3] != DBNull.Value ? Convert.ToString(row[3]) : null, // remember_token
                    CreatedAt = row[4] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[4]) : null, // created_at
                    UpdatedAt = row[5] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[5]) : null, // updated_at
                    Status = Convert.ToInt32(row[6]) // status
                };

                accounts.Add(account);
            }

            return accounts;
        }
        //id =@id";
        //var cmd = new MySqlCommand(sql);
        //cmd.Parameters.AddWithValue("@id", id);
        public static AccountDTO GetAccountById(long id)
        {
            string sql = "select * from account where id= @id"; // Câu lệnh SQL
            var cmd = new MySqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", id);

            List<List<object>> result = DBConnection.ExecuteReader(cmd);

            if (result.Count > 0)
            {
                List<object> row = result[0];
                AccountDTO khoa = new AccountDTO
                {
                    Id = Convert.ToInt64(row[0]), // id
                    Role = Convert.ToInt32(row[1]), // vaitro: Chuyển thành int
                    Password = Convert.ToString(row[2]), // password
                    RememberToken = row[3] != DBNull.Value ? Convert.ToString(row[3]) : null, // remember_token
                    CreatedAt = row[4] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[4]) : null, // created_at
                    UpdatedAt = row[5] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[5]) : null, // updated_at
                    Status = Convert.ToInt32(row[6]) // status
                };
                return khoa;
            }

            return null;
        }

        // string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(account.Password, 13);
        //hàm add account
        public static bool AddAccount(AccountDTO account)
        {
            try
            {
                string sql = "INSERT INTO account (id,vaitro, password, remember_token, created_at, updated_at, status) " +
                             "VALUES (@id,@role, @password, @rememberToken, @createdAt, @updatedAt, @status)";

                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(account.Password, 13); // Hash password

                using (var cmd = new MySqlCommand(sql))
                {
                    cmd.Parameters.AddWithValue("@id", account.Id);
                    cmd.Parameters.AddWithValue("@role", account.Role); // role là int
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@rememberToken", account.RememberToken ?? (object)DBNull.Value); // Handle null
                    cmd.Parameters.AddWithValue("@createdAt", account.CreatedAt ?? DateTime.Now); // Set default if null
                    cmd.Parameters.AddWithValue("@updatedAt", account.UpdatedAt ?? DateTime.Now); // Set default if null
                    cmd.Parameters.AddWithValue("@status", account.Status);

                    return DBConnection.ExecuteNonQuery(cmd) > 0; // Return true if success
                }
            }
            catch (MySqlException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        //$"INSERT INTO tài khoản mới khi thêm sinh viên + $"VALUES (@id)"
        public static bool AddAccountSV(AccountDTO account)
        {
            string sql = $"INSERT INTO account (id, vaitro, password, remember_token, created_at, updated_at, status) " +
                         $"VALUES (@id, @role, @password, @rememberToken, @createdAt, @updatedAt, @status)";

            var cmd = new MySqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", account.Id);
            cmd.Parameters.AddWithValue("@role", "Sinh viên");
            cmd.Parameters.AddWithValue("@password", account.Password);
            cmd.Parameters.AddWithValue("@rememberToken", null);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@status", 1);

            return DBConnection.ExecuteNonQuery(cmd) > 0;
        }
        public static bool AddAccountGV(AccountDTO account)
        {
            string sql = $"INSERT INTO account (id, vaitro, password, remember_token, created_at, updated_at, status) " +
                        $"VALUES (@id, @role, @password, @rememberToken, @createdAt, @updatedAt, @status)";

            var cmd = new MySqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", account.Id);
            cmd.Parameters.AddWithValue("@role", 2);  // Thay đổi vai trò thành Giảng viên
            cmd.Parameters.AddWithValue("@password", account.Password);
            cmd.Parameters.AddWithValue("@rememberToken", null);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@status", 1);

            return DBConnection.ExecuteNonQuery(cmd) > 0;
        }

        // Cập nhật thông tin tài khoản
        public static bool UpdateAccount(AccountDTO account)
        {
            string sql = $"UPDATE account SET vaitro = @role, password = @password, remember_token = @rememberToken, " +
                         $"created_at = @createdAt, updated_at = @updatedAt, status = @status WHERE id = @id";

            var cmd = new MySqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", account.Id);
            cmd.Parameters.AddWithValue("@role", account.Role); // role là int
            cmd.Parameters.AddWithValue("@password", account.Password);
            cmd.Parameters.AddWithValue("@rememberToken", account.RememberToken);
            cmd.Parameters.AddWithValue("@createdAt", account.CreatedAt);
            cmd.Parameters.AddWithValue("@updatedAt", account.UpdatedAt);
            cmd.Parameters.AddWithValue("@status", account.Status);

            return DBConnection.ExecuteNonQuery(cmd) > 0;
        }



        // Tìm kiếm tài khoản is null  theo nhiều tiêu chí voi LIKE CONCAT('%', @search, '%')
        public static List<AccountDTO> SearchAccounts(int vaitro, int status, string search)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            // Câu truy vấn SQL: tìm kiếm theo vaitro, status, và search trên id hoặc vaitro
            string sql = @"
SELECT * FROM account
WHERE
    (@vaitro IS NULL OR vaitro = @vaitro)
    AND (@status IS NULL OR status = @status)
    AND (@search IS NULL OR password LIKE CONCAT('%', @search, '%') OR id LIKE CONCAT('%', @search, '%'))";

            // Khởi tạo kết nối và câu lệnh SQL
            MySqlCommand cmd = new MySqlCommand(sql);
            try
            {
                // Thêm các tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@vaitro", vaitro == -1 ? (object)DBNull.Value : vaitro);
                cmd.Parameters.AddWithValue("@status", status == -1 ? (object)DBNull.Value : status);
                cmd.Parameters.AddWithValue("@search", string.IsNullOrEmpty(search) ? (object)DBNull.Value : $"%{search}%");

                // Sử dụng phương thức ExecuteReader từ DBConnection để thực thi truy vấn và lấy kết quả
                List<List<object>> result = DBConnection.ExecuteReader(cmd);

                // Duyệt qua từng dòng kết quả và ánh xạ sang đối tượng `AccountDTO`
                foreach (var row in result)
                {
                    AccountDTO account = new AccountDTO
                    {
                        Id = Convert.ToInt64(row[0]), // id
                        Role = Convert.ToInt32(row[1]), // vaitro
                        Password = Convert.ToString(row[2]), // password
                        RememberToken = row[3] != DBNull.Value ? Convert.ToString(row[3]) : null, // remember_token
                        CreatedAt = row[4] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[4]) : null, // created_at
                        UpdatedAt = row[5] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[5]) : null, // updated_at
                        Status = Convert.ToInt32(row[6]) // status
                    };

                    accounts.Add(account);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm tài khoản: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối và giải phóng tài nguyên
                if (cmd.Connection != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Dispose();
            }

            return accounts;
        }


        public static bool DeactivateAccount(long id)
        {
            string sql = "UPDATE account SET status = 0 WHERE id = @id";
            var cmd = new MySqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", id);

            return DBConnection.ExecuteNonQuery(cmd) > 0;
        }





        public static void PrintAllAccounts()
        {
            List<AccountDTO> accounts = GetAllAccounts(); // Lấy tất cả tài khoản

            // Kiểm tra nếu danh sách không rỗng
            if (accounts.Count > 0)
            {
                foreach (var account in accounts)
                {
                    // In thông tin tài khoản ra console
                    Console.WriteLine($"ID: {account.Id}, Role: {account.Role}, Password: {account.Password}, " +
                                      $"Remember Token: {account.RememberToken}, Created At: {account.CreatedAt}, " +
                                      $"Updated At: {account.UpdatedAt}, Status: {account.Status}");
                }
            }
            else
            {
                Console.WriteLine("Không có tài khoản nào trong cơ sở dữ liệu.");
            }
        }


        public static AccountDTO Login(string username, string plainPassword)
        {
            string sql = $"SELECT * FROM account WHERE id = @username and status=1";
            var cmd = new MySqlCommand(sql);
            cmd.Parameters.AddWithValue("@username", username);

            List<List<object>> result = DBConnection.ExecuteReader(cmd);

            if (result.Count > 0)
            {
                var row = result[0];
                string hashedPassword = Convert.ToString(row[2]);

                //Kiểm tra mật khẩu đã mã hóa với mật khẩu người dùng nhập.
                if (BCrypt.Net.BCrypt.EnhancedVerify(plainPassword, hashedPassword))
                {
                    return new AccountDTO
                    {
                        Id = Convert.ToInt64(row[0]),
                        Role = Convert.ToInt32(row[1]), // role là int
                        Password = hashedPassword,
                        RememberToken = Convert.ToString(row[3]),
                        CreatedAt = row[4] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[4]) : null,
                        UpdatedAt = row[5] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[5]) : null,
                        Status = Convert.ToInt32(row[6])
                    };
                }
            }

            return null; // Trả về null nếu đăng nhập không thành công.
        }


        //Đổi mật khẩu
        public static bool ChangePassword(long userId, string newPassword)
        {
            try
            {
                // Hash mật khẩu mới
                string newHashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword, 13);

                // Cập nhật mật khẩu mới
                string updateSql = "UPDATE account SET password = @newPassword, updated_at = @updatedAt WHERE id = @userId";
                var updateCmd = new MySqlCommand(updateSql);
                updateCmd.Parameters.AddWithValue("@newPassword", newHashedPassword);
                updateCmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
                updateCmd.Parameters.AddWithValue("@userId", userId);

                int rowsAffected = DBConnection.ExecuteNonQuery(updateCmd);

                if (rowsAffected > 0)
                {
                    return true; // Đổi mật khẩu thành công
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật mật khẩu");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }



    }
}
