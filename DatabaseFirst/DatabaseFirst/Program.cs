using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var dbContext = new LAB_EF_CTYEntities())
            {
                var nhanViens = dbContext.NhanVien
                    .Where(nv => nv.GioiTinh == "Nam" && nv.PhongBan.Ten == "Phòng Maketing" && nv.Tuoi >= 30 && nv.Tuoi <= 40)
                    .ToList();

                foreach (var nhanVien in nhanViens)
                {
                    Console.WriteLine($"Tên nhân viên: {nhanVien.Ten}, Tuổi: {nhanVien.Tuoi}, Phòng ban: {nhanVien.PhongBan.Ten}");
                }
            }
            Console.ReadKey();
        }
    }
}
