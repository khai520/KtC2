using KtC_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Service sv = new Service();
int menu;
do
{
    Console.WriteLine("1. Nhập 1 danh sách đối tượng");
    Console.WriteLine("2. Xuất danh sách đối tượng");
    Console.WriteLine("3. Lưu File - Đọc File");
    Console.WriteLine("4. Xóa đối tượng theo ID");
    Console.WriteLine("0. Thoát");
    Console.Write("Vui lòng nhập chương trình cần chọn :");
    menu = Convert.ToInt32(Console.ReadLine());
    switch (menu)
    {
        case 0:
            Console.WriteLine("Kết thúc chương trình!!");
            break;
        case 1:
            Console.WriteLine("1. Nhập 1 danh sách đối tượng");
            sv.Nhap();
            break;
        case 2:
            Console.WriteLine("2. Xuất danh sách đối tượng");
            sv.Xuat();
            break;
        case 3:
            Console.WriteLine("3. Lưu File - Đọc File");
            sv.LuuDoc();
            break;
        case 4:
            Console.WriteLine("4. Xóa đối tượng theo ID");
            sv.XoaID();
            break;

        default:
            Console.WriteLine("Không có chương trình cần tìm");
            break;
    }

} while (menu != 0);
