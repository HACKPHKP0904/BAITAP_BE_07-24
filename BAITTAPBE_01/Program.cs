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
            Console.OutputEncoding= Encoding.UTF8; 
            float a, b;
            Console.WriteLine("Nhập vào a :");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào b :");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Tổng 2 số {0} và {1} là {2}", a, b, a + b);
            Console.WriteLine("Hiệu 2 số {0} và {1} là {2}", a, b, a - b);
            Console.WriteLine("Tích 2 số {0} và {1} là {2}", a, b, a * b);
            if(b != 0)
            {
                Console.WriteLine("Thương 2 số {0} và {1} là {2}", a, b, a / b);
            }
            else
            {
                Console.WriteLine("Không thực hiện phép chia được do b <0 ");
            }

            //Bài 2: Viết Chương trình giải phương trình bậc 1 , bậc 2 ( 2x2 + 3x +1=0)
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Giải phương trình bậc nhất {0}x + {1} = 0",a,b);
            if (a != 0)
            {
                Console.WriteLine("Kết quả phương trình x = -{0} /{1}", b, a);

            }
            else{
                Console.WriteLine("Không thực hiện được phép chia");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Giải phương trình bậc 2 ax^2 + bx + c =0");
            float c;
            Console.WriteLine("Nhập vào số c :");
            c = float.Parse(Console.ReadLine());
            if (a != 0)
            {   
                if(b!=0)
                {
                    if(c!=0)
                    {
                        double delta = (b * b - 4*a*c);
                        if (delta > 0)
                        {
                            Console.WriteLine("Giá trị x1 = (-{0} + Math.Sqrt({1}))/2*{2}", b, delta, a);
                            Console.WriteLine("Giá trị x2 = (-{0} - Math.Sqrt({1}))/2*{2}", b, delta, a);

                        } else if (delta == 0)
                        {
                            Console.WriteLine("Giá trị của x = - {0} / 2 *{1}", b, a);
                        }
                        else
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }

                    }else
                    {
                        Console.WriteLine("Phương trình ax^2 + bx =0");
                        Console.WriteLine("Nghiệm x1 = 0");
                        Console.WriteLine("Nghiệm x2 = -{0}/{1}",b,a);
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình bậc 2  ax^2 + c = 0");
                    if (c != 0)
                    {
                        float nghiem = c / a;
                        if(nghiem <= 0)
                        {
                            if(c == 0 )
                            {
                                Console.WriteLine("Phương trình có 1 nghiệm thực x = 0");
                            }
                            if(c < 0 ) 
                            {
                                Console.WriteLine("Phương trình có 2 nghiệm ");
                                Console.WriteLine("Nghiệm x1 = Math.Sqrt(-{0}/{1})",c,a);
                                Console.WriteLine("Nghiệm x2 = -Math.Sqrt(-{0}/{1}",c,a);
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


            }else
            {
                Console.WriteLine("Phương trình có dạng bx + c = 0");
                if (b != 0)
                {
                    if (c != 0)
                    {
                        Console.WriteLine("Nghiệm x = -{0}/{1}", c, b);
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
            float C;
            Console.WriteLine("Nhập vào độ C :");
            C = float.Parse(Console.ReadLine());
            if(C == 0)
            {
                Console.WriteLine("Nhập lại độ C:");
                C = float.Parse((string) Console.ReadLine());
            }
            else
            {
                float K = 1 * C + 273;
                Console.WriteLine("Đổi sang độ K ");
                Console.WriteLine("Độ K = {0}",K);
                float F = C *18 / 10 + 32;
                Console.WriteLine("Đổi sang độ F");
                Console.WriteLine("Độ F = {0} ",F);
            }
            Console.ReadLine();

        }
    }
}
