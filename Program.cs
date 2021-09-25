using System;

namespace bai_tap_1
{
    class Program
    {
         static void Nhapmang(out int[] b,out int a)
         {
            Console.Write("Nhap do dai mang : ");
            a = int.Parse(Console.ReadLine());
            b = new int[a];
            Console.WriteLine("Nhap cac phan tu mang");
            for(int i = 0; i< b.Length;i++)
           {
            Console.Write("b[{0}]: ",i);
            b[i]=int.Parse(Console.ReadLine());
            }
         }
    
        static int Dem(int [] b)
        {
            // 2. Đếm số phần tử khác 0 của mảng
            int dem = 0;
            for(int i = 0; i< b.Length;i++)
            {
                if(b[i] != 0)
                {
                    dem++;
                }
            }
            return dem;
            
        }
        static void Sapxep1(int[]b)
        {
            int min = b[0];   
            //3. theo thứ tự tăng dần    
             for(int i = 0; i < b.Length; i++)
            {
                for(int j = i+1; j< b.Length; j++)
                {
                    if(b[i] > b[j])
                    {
                        int temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }
            
        }
        static void Sapxep2(int[]b)
        {
            int min = b[0];   
            //3. theo thứ tự giảm dần    
             for(int i = 0; i < b.Length; i++)
            {
                for(int j = i+1; j< b.Length; j++)
                {
                    if(b[i] < b[j])
                    {
                        int temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }
            
        }
        static void KTraSNTCN(int[]b)
        {
              for(int i = 0; i< b.Length;i++)
            {
                
                for(int j = i+1; j< b.Length;j++)
                {
                     int biendem = 0;
                    for(int y= 1; y <= Math.Min(b[i],b[j]);y++)
                    {
                        if(b[i] % y ==0 && b[j] % y == 0)
                        {
                            biendem++;
                        }                     
                    }
                    if (biendem == 1)
                    Console.Write("{0} và {1}; ",b[i],b[j]);
                }
            }
        }

      
       static void KiemTraSCP(int[] b, out int[] n,out int x)
        {
            // 5. Liệt kê các số chính phương
            x = 0;
            n = new int[b.Length];
          for(int i = 0; i < b.Length; i++)
          {
              if((double) b[i] == Math.Pow(Math.Round(Math.Sqrt(b[i]),0),2))
              {
                n[x] = b[i];
                x++;
              }
              
          }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            int a,x; int[] b; int[] n;
            Nhapmang(out b,out a);
            //1
            Console.WriteLine("Mang ban dau: ");
            for(int i = 0; i< a; i++)
            {
                Console.Write("{0} ",b[i]);
            }
            Console.WriteLine("");
            //2
           Console.WriteLine("So phan tu khac 0 trong mang la: {0}",Dem(b));
           //3
           Console.WriteLine("Sap xep theo thu tu tang dan: ");
           Sapxep1(b);
           for(int i = 0; i < a;i++){
               Console.Write("{0} ",b[i]);
           }
           Console.WriteLine("");
           Console.WriteLine("Sap xep theo thu tu giam dan: ");
           Sapxep2(b);
           for(int i = 0; i < a;i++){
               Console.Write("{0} ",b[i]);
           }
           Console.WriteLine("");
           //4          
           Console.WriteLine("So cap so nguyen to cung nhau trong mang: ");
           KTraSNTCN(b);
           Console.WriteLine("");
           // 5
           KiemTraSCP(b,out n,out x);
           Console.WriteLine("Cac so chinh phuong trong mang: ");
           for(int i = 0; i < x;i++)
           {
               Console.Write("{0} ",n[i]);
           }     
        }
    }
}
