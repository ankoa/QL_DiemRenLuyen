using ql_diemrenluyen.GUI.USER;

namespace ql_diemrenluyen
{
    internal static class Program
    {
        public static string nguoidung_id = "1";
        public static int role = 3;
        public static string type = "";
        public static CloudinaryService cloudinaryService = new CloudinaryService("dkw6fkmqz", "531931146844242", "yBVcWGd-GvwHBfw9FWFMO7rDgfk");
        //public static string nguoidung_id = "1";
        //public static string role = "Sinh Viên";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());
            //Application.Run(new chamdrl("Xem", 1, 4));

            //Application.Run(new Thongke()); // or Application.Run(new AdminStudentTest());
            //Application.Run(new ThongTinBangChung());

        }
    }
}
