using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITTAPBE_01
{
    internal class Program
    {
        /*
         * Họ tên : Phi Hùng
         * Ngày viết : 19/07/2024
         * Ngày sửa :
         */
        static void Main(string[] args)
        {
            // Bài 1: Viết chương trình C# để giải bài tập tìm tổng hai số , tích 2 số , hiệu 2 số 
            Console.OutputEncoding = Encoding.UTF8;
            float firstnumber = ReadLineFloat("Nhập vào a");
            float twonumber = ReadLineFloat("Nhập vào b");

            Console.WriteLine("Tổng 2 số {0} và {1} là {2}", firstnumber, twonumber, firstnumber + twonumber);
            Console.WriteLine("Hiệu 2 số {0} và {1} là {2}", firstnumber, twonumber, firstnumber - twonumber);
            Console.WriteLine("Tích 2 số {0} và {1} là {2}", firstnumber, twonumber, firstnumber * twonumber);
            if (twonumber != 0)
            {
                Console.WriteLine("Thương 2 số {0} và {1} là {2}", firstnumber, twonumber, firstnumber / twonumber);
            }
            else
            {
                Console.WriteLine("Không thực hiện phép chia được do b <0 ");
            }

            //Bài 2: Viết Chương trình giải phương trình bậc 1 , bậc 2 ( 2x2 + 3x +1=0)
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Giải phương trình bậc nhất {0}x + {1} = 0", firstnumber, twonumber);
            if (firstnumber != 0)
            {
                Console.WriteLine("Kết quả phương trình x = -{0} /{1}", twonumber, firstnumber);

            }
            else
            {
                Console.WriteLine("Không thực hiện được phép chia");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Giải phương trình bậc 2 ax^2 + bx + c =0");
            float threenumber = ReadLineFloat("Nhập vào số c");
            if (firstnumber != 0)
            {
                if (twonumber != 0)
                {
                    if (threenumber != 0)
                    {
                        double delta = (twonumber * twonumber - 4 * firstnumber * threenumber);
                        if (delta > 0)
                        {
                            Console.WriteLine("Giá trị x1 = (-{0} + Math.Sqrt({1}))/2*{2}", twonumber, delta, firstnumber);
                            Console.WriteLine("Giá trị x2 = (-{0} - Math.Sqrt({1}))/2*{2}", twonumber, delta, firstnumber);

                        }
                        else if (delta == 0)
                        {
                            Console.WriteLine("Giá trị của x = - {0} / 2 *{1}", twonumber, firstnumber);
                        }
                        else
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Phương trình ax^2 + bx =0");
                        Console.WriteLine("Nghiệm x1 = 0");
                        Console.WriteLine("Nghiệm x2 = -{0}/{1}", twonumber, firstnumber);
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình bậc 2  ax^2 + c = 0");
                    if (threenumber != 0)
                    {
                        float nghiem = threenumber / firstnumber;
                        if (nghiem <= 0)
                        {
                            if (threenumber == 0)
                            {
                                Console.WriteLine("Phương trình có 1 nghiệm thực x = 0");
                            }
                            if (threenumber < 0)
                            {
                                Console.WriteLine("Phương trình có 2 nghiệm ");
                                Console.WriteLine("Nghiệm x1 = Math.Sqrt(-{0}/{1})", threenumber, firstnumber);
                                Console.WriteLine("Nghiệm x2 = -Math.Sqrt(-{0}/{1}", threenumber, firstnumber);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phương trình có 1 nghiệm x = 0");
                    }
                }


            }
            else
            {
                Console.WriteLine("Phương trình có dạng bx + c = 0");
                if (twonumber != 0)
                {
                    if (threenumber != 0)
                    {
                        Console.WriteLine("Nghiệm x = -{0}/{1}", threenumber, twonumber);
                    }
                    else
                    {
                        Console.WriteLine("Phương trình có 1 nghiệm x = 0");
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }

            //Bài 3: Viết chương trình C# để giải bài tập chuyển đổi độ C thành độ K và độ F trong C# 
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Bài tập chuyễn đổi độ C");
            float do_C = ReadLineFloat("Nhập vào độ C");
            float do_K = 1 * do_C + 273;
            Console.WriteLine("Đổi sang độ K ");
            Console.WriteLine("Độ K = {0}", do_K);
            float do_F = do_C * 18 / 10 + 32;
            Console.WriteLine("Đổi sang độ F");
            Console.WriteLine("Độ F = {0} ", do_F);
            Console.ReadLine();
        }
        static float ReadLineFloat(string promt)
        {
            float number;
            Console.WriteLine(promt);
            while(!float.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Giá trị không hợp lệ , vui lòng nhập lại");
            }
            return number;
        }
    }
}
