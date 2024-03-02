using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HOMEPAGE
{
    internal class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Chuyển đổi chuỗi nhập vào thành một mảng byte và tính toán hash
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));

            // Chuyển đổi mảng byte thành một chuỗi
            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        // Phương thức kiểm tra mật khẩu với hash
        public static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            string hashOfInput = HashPassword(inputPassword);
            return hashOfInput == hashedPassword;
        }
    }
}
