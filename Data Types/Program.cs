using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiểu số nguyên
            int BienInt = 10;
            byte BienByte = 100;
            short BienShort = 50;
            long BienLong = 35;

            //Kiểu số thực
            float BienFloat = 10.5f; // Giá trị của biến kiểu float phải có hậu tố f hoặc F
            double BienDouble = 20.6; // Giá trị của biến kiểu double không cần hậu tố
            decimal BienDecimal = 15.5m; // Giá trị của biến kiểu decimal phải có hậu tố m.

            //Kiểu ký tự và kiểu chuỗi
            char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu ''
            string BienString = "QK"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu ""

            Console.WriteLine(BienInt);
            Console.WriteLine(BienByte);
            Console.WriteLine(BienShort);
            Console.WriteLine(BienLong);

            Console.WriteLine(BienFloat);
            Console.WriteLine(BienDouble);
            Console.WriteLine(BienDecimal);

            Console.WriteLine(BienChar);
            Console.WriteLine(BienString);

            Console.ReadKey();
        }
    }
}

//Kiểu dữ liệu là gì
/*
 * - Là tập hợp các nhóm dữ liệu có cùng đặc tính, các lưu trữ và thao tác xử lý trên trường dữ liệu đó
 * - Là một tín hiệu để trình biên dịch nhận biết kích thước của một biến
 * - Là thành phần cốt lõi của một ngôn ngữ lập trình
 */