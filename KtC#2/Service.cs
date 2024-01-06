using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtC_2
{
    internal class Service
    {
        List<Bike> list = new List<Bike>();
        int i;
        public void checkId()
        {
            i = 0;
            foreach (Bike bike in list)
            {
                if (bike.Id == i)
                {
                    i++;
                }
            }
        }
        public void Nhap()
        {
            string check = "0";
            do
            {
                checkId();
                Console.WriteLine("Id:" + i);
                int Id = i;
                Console.WriteLine("Nhập tên:");
                string ten = Console.ReadLine();
                Console.WriteLine("Nhập hãng sản xuất:");
                string hsx = Console.ReadLine();
                list.Add(new Bike() { Id = Id, Ten = ten, Hsx = hsx });
                Console.WriteLine("Bạn có muốn nhập tiếp không (0/n - 1/y):");
                check = Console.ReadLine(); 
            } while (check == "1" || check.ToLower() == "y");
        }
        public void Xuat()
        {
            list.ForEach(x => x.inThongTin());
        }
        public void LuuDoc()
        {
            string path = @"C:\Users\khai5\source\repos\KtC#2\KtC#2\list.txt";
            List<string> saveFile = new List<string>();
            foreach (Bike bike in list)
            {
                saveFile.Add($"{bike.Id}|{bike.Ten}|{bike.Hsx}");
            }
            File.WriteAllLines(path, saveFile.ToArray());
            var docfile = File.ReadAllLines(path);
            foreach (var item in docfile)
            {
                Console.WriteLine(item);
                string[] a = item.Trim().Split("|");
                if(list.Find(x => x.Id == Convert.ToInt32(a[0])) == null){
                    list.Add(new Bike
                    {
                        Id = Convert.ToInt32(a[0]),
                        Ten = a[1],
                        Hsx = a[2]
                    });
                }
            }
        }
        public void XoaID()
        {
            Console.WriteLine("Nhập id cần xóa:");
            int id = Convert.ToInt32(Console.ReadLine());
            if (list.Find(x => x.Id == id) != null)
            {
                list.Remove(list.Find(x => x.Id == id));
            }
            else
            {
                Console.WriteLine("Không có id cần xóa");
            }
        }
    }
}
