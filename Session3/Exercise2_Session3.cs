using System;
using System.Globalization; 
using System.Text;
class Program
{

    //Tính tiền điện sinh hoạt gia đình theo bậc thang (EVN)
    static void Bai1()
    {
         Console.WriteLine("--- INTPUT ---");
        Console.Write("Nhập chỉ số điện cũ (kWh): ");
        decimal chiSoCu = decimal.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập chỉ số điện mới (kWh): ");
        decimal chiSoMoi = decimal.Parse(Console.ReadLine() ?? "0");

        if (chiSoMoi < chiSoCu)
        {
            Console.WriteLine("Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
            return;
        }

        decimal soKwh = chiSoMoi - chiSoCu;
        decimal tienChuaThue = 0m;

        if (soKwh <= 50)
        {
            tienChuaThue = soKwh * 1806m;
        }
        else if (soKwh <= 100)
        {
            tienChuaThue = (50 * 1806m) + (soKwh - 50) * 1866m;
        }
        else if (soKwh <= 200)
        {
            tienChuaThue = (50 * 1806m) + (50 * 1866m) + (soKwh - 100) * 2167m;
        }
        else if (soKwh <= 300)
        {
            tienChuaThue = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (soKwh - 200) * 2729m;
        }
        else
        {
            tienChuaThue = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (100 * 2729m) + (soKwh - 300) * 3050m;
        }

        decimal thueVat = tienChuaThue * 0.08m;
        decimal tongThanhToan = tienChuaThue + thueVat;

         Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Số điện tiêu thụ: {soKwh} kWh");
        Console.WriteLine($"Tiền điện chưa thuế: {tienChuaThue:#,##0} VNĐ");
        Console.WriteLine($"Thuế VAT (8%): {thueVat:#,##0} VNĐ");
        Console.WriteLine($"Tổng thanh toán: {tongThanhToan:#,##0} VNĐ");
    }
    //Hệ thống theo dõi chỉ số BMI và đánh giá tình trạng sức khoẻ
    static void Bai2()
    {
        Console.WriteLine("--- INTPUT ---");
        double chieuCao, canNang;
        Console.Write("Chiều cao (m): ");
        chieuCao = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Cân nặng (kg): ");
        canNang = double.Parse(Console.ReadLine() ?? "0");
        double BMI = canNang / Math.Pow(chieuCao,2);
        string WHO; 
        if(BMI < 18.5)
        {
            WHO = "Gầy (Thiếu cân)";
        } else if (BMI >= 18.5 && BMI <= 23.0)
        {
              WHO= "Bình thường (Lý tưởng)";
        } else if (BMI >= 23.0 && BMI <= 25.0)
        {
             WHO= "Thừa cân (Tiền béo phì)";
        } else 
        {
             WHO = "Béo phì";
        }
        double canNangToiThieu = 18.5D * Math.Pow(chieuCao,2);
        double canNangToiDa = 22.9D * Math.Pow(chieuCao,2);
        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
        Console.WriteLine($"Phân loại sức khoẻ: {WHO}");
        Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangToiThieu:F2} kg đến {canNangToiDa:F2} kg");
    }
    //Ứng dụng quy đổi tiền tệ ngoại tệ đa tỷ giá ngân hàng
   enum CurrencyType
    {
        
        None,
        USD,
        EUR,
        JPY,
        GBP

    }
       static void Bai3()
    {

        const decimal USD = 1m / 25400m;
        const decimal EUR = 1m / 27200m;
        const decimal JPY = 1m / 165m;
        const decimal GBP = 1m / 32100m;

        decimal VND = 0m;
        int loaiNgoaiTe = 0;
        Console.WriteLine("--- INTPUT ---");

        Console.Write("Nhập số tiền VNĐ: ");
        if (!decimal.TryParse(Console.ReadLine(), out VND) || VND <= 0)
        {
            Console.WriteLine("Lỗi: Số tiền VNĐ nhập vào không hợp lệ!");
            return;
        }

        decimal phiDichVu = 0.005m * VND;
        decimal tienVietNamSauPhi = VND - phiDichVu;
        decimal tienNhanDuoc = 0m;
        CurrencyType myCurrency = CurrencyType.None;

        Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
        if (!int.TryParse(Console.ReadLine(), out loaiNgoaiTe))
        {
            Console.WriteLine("Lỗi: Vui lòng nhập số từ 1 đến 4!");
            return;
        }

        switch (loaiNgoaiTe)
        {
            case 1:
                myCurrency = CurrencyType.USD;
                tienNhanDuoc = tienVietNamSauPhi * USD;
                break;
            case 2:
                myCurrency = CurrencyType.EUR;
                tienNhanDuoc = tienVietNamSauPhi * EUR;
                break;
            case 3:
                myCurrency = CurrencyType.JPY;
                tienNhanDuoc = tienVietNamSauPhi * JPY;
                break;
            case 4:
                myCurrency = CurrencyType.GBP;
                tienNhanDuoc = tienVietNamSauPhi * GBP;
                break;
            default:
                Console.WriteLine("Lỗi: Lựa chọn ngoại tệ không phù hợp!");
                return;
        }

        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:#,##0.00} VNĐ");
        Console.WriteLine($"Số tiền VNĐ tính đổi: {tienVietNamSauPhi:#,##0.00} VNĐ");
        Console.WriteLine($"Số tiền {myCurrency} nhận được: {tienNhanDuoc:#,##0.00} {myCurrency}");
    }  
      
    //Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật
       static void Bai4()
    {
        Console.WriteLine("--- INPUT --- ");
        DateTime ngaySinh;
        Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
        while (true)
        {
            string input = Console.ReadLine() ?? "";
            if(DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                if(ngaySinh > DateTime.Now)
                {
                    Console.WriteLine("Ngày sinh bạn nhập vượt qua ngày sinh hiện tại");
                    continue;
                }
                break;
                
            } Console.WriteLine("Lỗi ngày sinh không hợp lệ theo cú pháp dd/MM/yyyy");
        }
        DateTime hienTai = DateTime.Now;
        TimeSpan khoangThoiGian = hienTai - ngaySinh;

        int tuoi = hienTai.Year - ngaySinh.Year;
        if(hienTai < ngaySinh.AddYears(tuoi))
        {
            tuoi --;
        }
        
        int soNgayDaSong = (int)khoangThoiGian.TotalDays;

        DateTime sinhNhatTiepTheo = new DateTime(hienTai.Year, ngaySinh.Month, ngaySinh.Day);

        if (sinhNhatTiepTheo < DateTime.Now)
        {
            sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
        }
        TimeSpan khoangThoiGianDenSinhNhat = sinhNhatTiepTheo - hienTai;
        int soNgayConLai = (int)khoangThoiGianDenSinhNhat.TotalDays;
        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Tuổi hiện tại: {tuoi} ");
        Console.WriteLine($"Bạn đã sống tổng cộng:{soNgayDaSong} ");
        Console.WriteLine($"Sinh nhật tiếp theo:{soNgayConLai} ");
        Console.ReadLine();
    }
    enum loaiDiem
    {
        None,
        A,
        B,
        C,
        D,
        F,
    }

    //Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0)
    static void Bai5()
    {
        double Csharp, toan, tiengAnh;
        Console.WriteLine("--- INPUT --- ");
        while (true)
    {
        Console.Write("C# (4 TC): ");
        if (double.TryParse(Console.ReadLine(), out Csharp) && Csharp >= 0 && Csharp <= 10)
        {
            break; 
        }
        Console.WriteLine("Lỗi: Điểm phải là số từ 0 đến 10. Vui lòng nhập lại!\n");
    }
    while (true)
    {
        Console.Write("Toán (3 TC): ");
        if (double.TryParse(Console.ReadLine(), out toan) && toan >= 0 && toan <= 10)
        {
            break;
        }
        Console.WriteLine("Lỗi: Điểm phải là số từ 0 đến 10. Vui lòng nhập lại!\n");
    }
    while (true)
    {
        Console.Write("Tiếng Anh (2 TC): ");
        if (double.TryParse(Console.ReadLine(), out tiengAnh) && tiengAnh >= 0 && tiengAnh <= 10)
        {
            break;
        }
        Console.WriteLine("Lỗi: Điểm phải là số từ 0 đến 10. Vui lòng nhập lại!\n");
    }

        int soTinChiCsharp = 4;
        int soTinChiToan = 3;
        int soTinChiTiengAnh = 2;
        loaiDiem xepLoai = loaiDiem.None;
        double GPA;
        string hocLuc;

        double diemTrungBinhTrongSo = (Csharp * soTinChiCsharp + toan * soTinChiToan + tiengAnh * soTinChiTiengAnh) / (soTinChiCsharp + soTinChiToan + soTinChiTiengAnh);

        if (diemTrungBinhTrongSo >= 8.5)
        {
            xepLoai = loaiDiem.A;
            GPA = 4.0;
            hocLuc = "Xuất sắc / Giỏi";
        }
        else if (diemTrungBinhTrongSo >= 7.0)
        {
            xepLoai = loaiDiem.B;
            GPA = 3.0;
            hocLuc = "Khá";
        }
        else if (diemTrungBinhTrongSo >= 5.5)
        {
            xepLoai = loaiDiem.C;
            GPA = 2.0;
            hocLuc = "Trung bình";
        }
        else if (diemTrungBinhTrongSo >= 4.0)
        {
            xepLoai = loaiDiem.D;
            GPA = 1.0;
            hocLuc = "Yếu";
        }
        else
        {
            xepLoai = loaiDiem.F;
            GPA = 0.0;
            hocLuc = "Kém (Trượt)";
        }
        Console.WriteLine("--- OUTPUT --- ");
        Console.WriteLine($"Điểm TB thang 10: {diemTrungBinhTrongSo:F2}");
        Console.WriteLine($"Điểm chữ quy đổi: {xepLoai}");
        Console.WriteLine($"Điểm GPA thang 4: {GPA}");
        Console.WriteLine($"Xếp loại học lực: {hocLuc}");
    }
    //Chuẩn Hóa Họ Tên Người Dùng & Tự Động Tạo Email/Username
    static void Bai6()
{
    Console.WriteLine("--- INPUT ---");
    Console.Write("Nhập họ tên thô: ");
    string tenTho = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(tenTho))
    {
        Console.WriteLine("Chuỗi nhập vào rỗng!");
        return;
    }

    string[] chuanHoa = tenTho.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < chuanHoa.Length; i++)
    {
        string vietThuong = chuanHoa[i].ToLower();
        string chuDauVietHoa = vietThuong.Substring(0, 1).ToUpper();
        string chuSauVietThuong = vietThuong.Substring(1);

        chuanHoa[i] = chuDauVietHoa + chuSauVietThuong;
    }

    string hoTenChuan = string.Join(" ", chuanHoa);

    int soLuongTu = chuanHoa.Length;
    string ho = chuanHoa[0];
    string ten = chuanHoa[soLuongTu - 1];
    string tenDem = "";

    if (soLuongTu > 2)
    {
        string[] mangtenDem = new string[soLuongTu - 2];
        Array.Copy(chuanHoa, 1, mangtenDem, 0, soLuongTu - 2);
        tenDem = string.Join(" ", mangtenDem);
    }

    string text = hoTenChuan.ToLower();

    string[] dau = {
        "aàáảãạâầấẩẫậăằắẳẵặ",
        "eèéẻẽẹêềếểễệ",
        "iìíỉĩị",
        "oòóỏõọôồốổỗộơờớởỡợ",
        "uùúủũụưừứửữự",
        "yỳýỷỹỵ",
        "dđ"
    };
    string[] khongDau = { "a", "e", "i", "o", "u", "y", "d" };

    for (int i = 0; i < dau.Length; i++)
    {
        foreach (char c in dau[i])
        {
            text = text.Replace(c.ToString(), khongDau[i]);
        }
    }

    string[] dsTu = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    string tenKhongDau = dsTu[dsTu.Length - 1];
    string username = "";

    if (dsTu.Length == 1)
    {
        username = tenKhongDau;
    }
    else
    {
        string hoVaTenDem = string.Join("", dsTu, 0, dsTu.Length - 1);
        username = $"{tenKhongDau}.{hoVaTenDem}";
    }

    Console.WriteLine($"\n--- OUTPUT ---");
    Console.WriteLine($"Họ và tên chuẩn hoá: {hoTenChuan}");
    Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
    Console.WriteLine($"Username tạo tự động: {username}");
    Console.WriteLine($"Email cấp phát: {username}@company.edu.vn");
}    
    //Lập Kế Hoạch Chi Phí Nhiên Liệu & Chia Sẻ Chuyến Đi (Car-pooling)
        static void Bai7()
    {
        Console.WriteLine("--- INPUT --- ");
        double khoangCach, nhienLieu;
        decimal giaXang;
        int soNguoi;
        Console.Write("Quãng đường (km): ");
        if(!double.TryParse(Console.ReadLine(), out khoangCach)){
            Console.WriteLine("Quãng đường không hợp lệ");
            return;
        }
        Console.Write("Mức tiêu hao (L/100km): ");
        if(!double.TryParse(Console.ReadLine(), out nhienLieu)){
            Console.WriteLine("Nhiên liệu không hợp lệ");
            return;
        }
        Console.Write("Giá xăng (VND/lít): ");
        if(!decimal.TryParse(Console.ReadLine(), out giaXang)){
            Console.WriteLine("Giá xăng không hợp lệ");
            return;
        }
        Console.Write("Số người đi: ");
        if(!int.TryParse(Console.ReadLine(), out soNguoi)){
            Console.WriteLine("Số người đi không hợp lệ");
            return;
        }

        double tongSoLitXang = (khoangCach / 100) * nhienLieu;
        decimal chiPhiXang = (decimal)tongSoLitXang * giaXang;
        decimal soTienMoiNguoi = Math.Ceiling(chiPhiXang / soNguoi);

        Console.WriteLine("--- OUTPUT --- ");
        Console.WriteLine($" Tổng nhiên liệu tiêu thụ: {tongSoLitXang:N2} lít");
        Console.WriteLine($" Tổng chi phí xăng dầu: {chiPhiXang:N0} VND");
        Console.WriteLine($" Chi phí mỗi người: {soTienMoiNguoi:N0} VND");
        Console.ReadLine();

    }
    static void Bai8()
    {
       
        string systemOTP = "839201";
        DateTime creationTime = DateTime.Now;

       Console.WriteLine("---INPUT---");
       Console.Write("Mã OTP nhận được: ");
       string inputOTP = Console.ReadLine()?.Trim() ?? " ";

       Console.Write("Thời gian trôi qua: ");
       if(!int.TryParse(Console.ReadLine(), out int secondPassed) || secondPassed < 0)
        {
            Console.WriteLine("Trạng thái xác thực: LỖI - Thời gian giả lập không hợp lệ.");
            return;
        }

        DateTime verifyTime = creationTime.AddSeconds(secondPassed);
        TimeSpan duration = verifyTime - creationTime;

        Console.WriteLine("---OUTPUT---");

        bool isValidFormat = inputOTP.Length == 6 && ulong.TryParse(inputOTP, out _);
        if (!isValidFormat)
        {
            Console.WriteLine("Trạng thái xác thực: LỖI - Định dạng không hợp lệ (phải chứa đúng 6 chữ số).");
            return;
        }

        if (duration.TotalSeconds > 300)
        {
            Console.WriteLine($"Trạng thái xác thực: LỖI - Hết hạn OTP (Đã trôi qua {duration.Minutes} phút {duration.Seconds} giây).");
            return;
        }

        if (inputOTP != systemOTP)
        {
            Console.WriteLine("Trạng thái xác thực: LỖI - Mã sai.");
            return;
        }
        Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
    
    }
    //Máy Tính Lương Gross - Net & Thuế TNCN Nhân Viên
    static void Bai9()
    {
        decimal luongGross;
        int soNguoiPhuThuoc;
        Console.WriteLine("---INPUT---");
        Console.Write("Lương Gross: ");
        decimal.TryParse(Console.ReadLine(), out luongGross);
        Console.Write("Số người phụ thuộc: ");
        int.TryParse(Console.ReadLine(), out soNguoiPhuThuoc);

        //const float BHXH = 0.08f * luongGross;
        //const float BHYT = 0.15f * luongGross;
        //const float BHTN = 0.01f * luongGross;
        decimal thueThuNhapCaNhan;
        const int mucBanThan = 11000000;
        decimal tong = 0.105m * luongGross;
        decimal thuNhapChiuThue = luongGross - tong - mucBanThan - (soNguoiPhuThuoc * 4400000);

        if(thuNhapChiuThue <= 0)
        {
            thuNhapChiuThue = 0;
        }

        if(thuNhapChiuThue > 0 && thuNhapChiuThue <= 5000000)
        {
            thueThuNhapCaNhan = 0.05m * thuNhapChiuThue;

        }
        else if(thuNhapChiuThue <= 10000000)
        {
            thueThuNhapCaNhan = (0.05m * 5000000) + (0.1m * (thuNhapChiuThue - 5000000));

        }
        else if(thuNhapChiuThue <= 18000000)
        {
            thueThuNhapCaNhan = (0.05m * 5000000) + (0.1m * 5000000) + (0.15m * (thuNhapChiuThue - 10000000));
        }

        else
        {
            thueThuNhapCaNhan = 0;
        }
        decimal luongNet = luongGross - tong - thueThuNhapCaNhan;
        Console.WriteLine("---OUTPUT");
        Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {tong:N0} VNĐ");
        Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ"); 
        Console.WriteLine($"Thuế TNCN phải nộp: {thueThuNhapCaNhan:N0} VNĐ");
        Console.WriteLine($"Lương NET thực nhận: {luongNet:N0} VNĐ");

    }
    //Quản Lý Tồn Kho & Xử Lý Giá Trị Khuyết Thiếu (Nullable Types)
   enum StockStatus
{
    OutOfStock,
    LowStock,
    InStock,
    Discontinued
}
    static void Bai10()
    {
        string productId = "KB-09";
        string productName = "Bàn phím Cơ Akko";
        int? quantity = null;            
        int minThreshold = 10;            
        DateTime? restockDate = null;    

        
        int displayQuantity = quantity ?? 0;

        
        StockStatus status;
        if (quantity == null || quantity == 0)
        {
            status = StockStatus.OutOfStock;
        }
        else if (quantity < minThreshold)
        {
            status = StockStatus.LowStock;
        }
        else
        {
            status = StockStatus.InStock;
        }

        
        string restockText = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập";

    
        Console.WriteLine("---INPUT---");
        Console.WriteLine($"Sản phẩm: {productName} (Mã: {productId})");
        Console.WriteLine($"Số lượng tồn kho: {(quantity.HasValue ? quantity.Value.ToString() : "null (Chưa kiểm kê)")}");
        Console.WriteLine($"Restock Date: {(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");

        Console.WriteLine("--- OUTPUT ---");
        Console.WriteLine($"Số lượng hiển thị: {displayQuantity} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");
        Console.WriteLine($"Trạng thái kho: {status} (Hết hàng)");
        Console.WriteLine($"Dự kiến nhập hàng: {restockText}");
    }
    static void Main()
    {
        Bai10();
    }
}

