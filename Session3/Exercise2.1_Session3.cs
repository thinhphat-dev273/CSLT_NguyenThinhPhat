using System;

namespace BaiTapCS
{
    //Bài 1
    public static (decimal TienChuaThue, decimal ThueVat, decimal TongThanhToan) TinhTienDien(decimal soKwh)
        {
            if (soKwh < 0) return (0, 0, 0);

            decimal tienChuaThue;
            if (soKwh <= 50)
                tienChuaThue = soKwh * 1806m;
            else if (soKwh <= 100)
                tienChuaThue = (50 * 1806m) + (soKwh - 50) * 1866m;
            else if (soKwh <= 200)
                tienChuaThue = (50 * 1806m) + (50 * 1866m) + (soKwh - 100) * 2167m;
            else if (soKwh <= 300)
                tienChuaThue = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (soKwh - 200) * 2729m;
            else
                tienChuaThue = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (100 * 2729m) + (soKwh - 300) * 3050m;

            decimal thueVat = tienChuaThue * 0.08m;
            decimal tongThanhToan = tienChuaThue + thueVat;

            return (tienChuaThue, thueVat, tongThanhToan);
        }
    //Bài 2
    public static (double Bmi, string PhanLoai, double CanNangMin, double CanNangMax) TinhBMI(double chieuCao, double canNang)
        {
            double bmi = canNang / Math.Pow(chieuCao, 2);
            string phanLoai;

            if (bmi < 18.5) phanLoai = "Gầy (Thiếu cân)";
            else if (bmi <= 23.0) phanLoai = "Bình thường (Lý tưởng)";
            else if (bmi <= 25.0) phanLoai = "Thừa cân (Tiền béo phì)";
            else phanLoai = "Béo phì";

            double canNangMin = 18.5 * Math.Pow(chieuCao, 2);
            double canNangMax = 22.9 * Math.Pow(chieuCao, 2);

            return (bmi, phanLoai, canNangMin, canNangMax);
        }
    //Bài 3
    public static decimal TinhPhiDichVu(decimal vnd)
        {
            return vnd * 0.005m;
        }

        public static decimal TinhTienQuyDoi(decimal tienSauPhi, int loaiNgoaiTe)
        {
            decimal tyGia = 0m;
            switch (loaiNgoaiTe)
            {
                case 1: tyGia = 1m / 25400m; break; // USD
                case 2: tyGia = 1m / 27200m; break; // EUR
                case 3: tyGia = 1m / 165m; break;   // JPY
                case 4: tyGia = 1m / 32100m; break; // GBP
            }
            return tienSauPhi * tyGia;
        }

        public static string LayTenNgoaiTe(int loaiNgoaiTe)
        {
            switch (loaiNgoaiTe)
            {
                case 1: return "USD";
                case 2: return "EUR";
                case 3: return "JPY";
                case 4: return "GBP";
                default: return "Không xác định";
            }
        }
    //Bài 4
    public class Bai04_TinhTuoiSinhNhat
    {
        public static int TinhTuoi(DateTime ngaySinh, DateTime hienTai)
        {
            int tuoi = hienTai.Year - ngaySinh.Year;
            if (hienTai < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }
            return tuoi;
        }

        public static int TinhSoNgayDaSong(DateTime ngaySinh, DateTime hienTai)
        {
            TimeSpan khoangThoiGian = hienTai - ngaySinh;
            return (int)khoangThoiGian.TotalDays;
        }

        public static int TinhSoNgayConLaiDenSinhNhat(DateTime ngaySinh, DateTime hienTai)
        {
            DateTime sinhNhatTiepTheo = new DateTime(hienTai.Year, ngaySinh.Month, ngaySinh.Day);
            if (sinhNhatTiepTheo < hienTai)
            {
                sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
            }
            TimeSpan khoangThoiGian = sinhNhatTiepTheo - hienTai;
            return (int)khoangThoiGian.TotalDays;
        }
    //Bài 5
        public static double TinhDiemTrungBinh(double csharp, double toan, double tiengAnh)
        {
            return (csharp * 4 + toan * 3 + tiengAnh * 2) / 9.0;
        }

        public static string QuyDoiDiemChu(double dtb)
        {
            if (dtb >= 8.5) return "A";
            if (dtb >= 7.0) return "B";
            if (dtb >= 5.5) return "C";
            if (dtb >= 4.0) return "D";
            return "F";
        }

        public static double QuyDoiGpa(double dtb)
        {
            if (dtb >= 8.5) return 4.0;
            if (dtb >= 7.0) return 3.0;
            if (dtb >= 5.5) return 2.0;
            if (dtb >= 4.0) return 1.0;
            return 0.0;
        }

        public static string XepLoaiHocLuc(double dtb)
        {
            if (dtb >= 8.5) return "Xuất sắc / Giỏi";
            if (dtb >= 7.0) return "Khá";
            if (dtb >= 5.5) return "Trung bình";
            if (dtb >= 4.0) return "Yếu";
            return "Kém (Trượt)";
        }
    //Bài 6
    public static string ChuanHoa(string tenTho)
        {
            string[] tu = tenTho.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tu.Length; i++)
            {
                string vietThuong = tu[i].ToLower();
                tu[i] = char.ToUpper(vietThuong[0]) + vietThuong.Substring(1);
            }
            return string.Join(" ", tu);
        }

        // Bỏ dấu tiếng Việt
        public static string LoaiBoDau(string text)
        {
            string textThuong = text.ToLower();
            string[] dau = { "aàáảãạâầấẩẫậăằắẳẵặ", "eèéẻẽẹêềếểễệ", "iìíỉĩị", "oòóỏõọôồốổỗộơờớởỡợ", "uùúủũụưừứửữự", "yỳýỷỹỵ", "dđ" };
            string[] khongDau = { "a", "e", "i", "o", "u", "y", "d" };

            for (int i = 0; i < dau.Length; i++)
            {
                foreach (char c in dau[i])
                {
                    textThuong = textThuong.Replace(c.ToString(), khongDau[i]);
                }
            }
            return textThuong;
        }

        // Tạo Username từ tên chuẩn hóa
        public static string TaoUsername(string hoTenChuan)
        {
            string khongDau = LoaiBoDau(hoTenChuan);
            string[] dsTu = khongDau.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            string ten = dsTu[dsTu.Length - 1];
            if (dsTu.Length == 1) return ten;

            string hoVaDem = "";
            for (int i = 0; i < dsTu.Length - 1; i++)
            {
                hoVaDem += dsTu[i];
            }
            return ten + "." + hoVaDem;
        }
    //Bài 7
    public static double TinhTongLitXang(double khoangCach, double nhienLieu)
        {
            return (khoangCach / 100.0) * nhienLieu;
        }

        public static decimal TinhTongChiPhi(double tongLitXang, decimal giaXang)
        {
            return (decimal)tongLitXang * giaXang;
        }

        public static decimal TinhChiPhiMoiNguoi(decimal tongChiPhi, int soNguoi)
        {
            return Math.Ceiling(tongChiPhi / soNguoi);
        }
    //Bài 8
    public static string KiemTraXacThuc(string inputOTP, string systemOTP, int secondPassed)
        {
            // Kiểm tra định dạng 6 chữ số
            if (inputOTP.Length != 6 || !ulong.TryParse(inputOTP, out _))
            {
                return "Trạng thái xác thực: LỖI - Định dạng không hợp lệ (phải chứa đúng 6 chữ số).";
            }

            // Kiểm tra thời gian
            if (secondPassed > 300)
            {
                int phut = secondPassed / 60;
                int giay = secondPassed % 60;
                return "Trạng thái xác thực: LỖI - Hết hạn OTP (Đã trôi qua " + phut + " phút " + giay + " giây).";
            }

            // Kiểm tra mã
            if (inputOTP != systemOTP)
            {
                return "Trạng thái xác thực: LỖI - Mã sai.";
            }

            return "Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.";
        }
    //Bài 9
    public static decimal TinhBaoHiem(decimal luongGross)
        {
            return 0.105m * luongGross;
        }

        public static decimal TinhThuNhapChiuThue(decimal luongGross, decimal baoHiem, int soNguoiPhuThuoc)
        {
            decimal mucBanThan = 11000000m;
            decimal mucPhuThuoc = soNguoiPhuThuoc * 4400000m;
            decimal thuNhap = luongGross - baoHiem - mucBanThan - mucPhuThuoc;

            if (thuNhap < 0) return 0m;
            return thuNhap;
        }

        public static decimal TinhThueTncn(decimal thuNhapChiuThue)
        {
            if (thuNhapChiuThue <= 0) return 0m;

            if (thuNhapChiuThue <= 5000000m)
            {
                return 0.05m * thuNhapChiuThue;
            }
            else if (thuNhapChiuThue <= 10000000m)
            {
                return (0.05m * 5000000m) + (0.1m * (thuNhapChiuThue - 5000000m));
            }
            else if (thuNhapChiuThue <= 18000000m)
            {
                return (0.05m * 5000000m) + (0.1m * 5000000m) + (0.15m * (thuNhapChiuThue - 10000000m));
            }

            return 0m;
        }

        public static decimal TinhLuongNet(decimal luongGross, decimal baoHiem, decimal thueTncn)
        {
            return luongGross - baoHiem - thueTncn;
        }
    //Bài 10
    public static int LaySoLuongHienThi(int? quantity)
        {
            if (quantity == null) return 0;
            return quantity.Value;
        }

        public static string TinhTrangThai(int? quantity, int minThreshold)
        {
            if (quantity == null || quantity == 0)
            {
                return "OutOfStock";
            }
            else if (quantity < minThreshold)
            {
                return "LowStock";
            }
            else
            {
                return "InStock";
            }
        }

        public static string LayNgayRestock(DateTime? restockDate)
        {
            if (restockDate == null)
            {
                return "Chưa có lịch nhập hàng";
            }
            return restockDate.Value.ToString("dd/MM/yyyy");
        }
    //Bài 11
    public static decimal TinhLaiDon(decimal tienGui, double laiSuatNam, int kyHanThang)
        {
            return tienGui * ((decimal)laiSuatNam / 100m) * (kyHanThang / 12m);
        }

        public static decimal TinhLaiKep(decimal tienGui, double laiSuatNam, int kyHanThang)
        {
            double coSo = 1.0 + (laiSuatNam / 100.0) / 12.0;
            decimal tongTien = (decimal)((double)tienGui * Math.Pow(coSo, kyHanThang));
            return tongTien - tienGui;
        }

        public static string SoSanhLoiNhuan(decimal laiDon, decimal laiKep)
        {
            if (laiDon > laiKep)
            {
                return "(Lãi đơn tối ưu hơn)";
            }
            else if (laiKep > laiDon)
            {
                return "(Lãi kép tối ưu hơn)";
            }
            return "(Không lãi suất nào tối ưu hơn)";
        }
    //Bài 12
    public static string MaHoa(string text, int k)
        {
            char[] result = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)('A' + (c - 'A' + k) % 26);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    result[i] = (char)('a' + (c - 'a' + k) % 26);
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }

        public static string GiaiMa(string encryptedText, int k)
        {
            char[] result = new char[encryptedText.Length];
            for (int i = 0; i < encryptedText.Length; i++)
            {
                char c = encryptedText[i];
                if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)('A' + (c - 'A' - k + 26) % 26);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    result[i] = (char)('a' + (c - 'a' - k + 26) % 26);
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }
    //Bài 13
    public static decimal TinhPhi2GioDau(string loaiXe)
        {
            string xe = loaiXe.Trim().ToLower();
            if (xe == "motorbike" || xe == "xe máy") return 5000m;
            if (xe == "car" || xe == "ô tô") return 20000m;
            if (xe == "truck" || xe == "xe tải") return 50000m;
            return 0m;
        }

        public static decimal TinhPhiGioSau(string loaiXe)
        {
            string xe = loaiXe.Trim().ToLower();
            if (xe == "motorbike" || xe == "xe máy") return 2000m;
            if (xe == "car" || xe == "ô tô") return 10000m;
            if (xe == "truck" || xe == "xe tải") return 25000m;
            return 0m;
        }

        public static decimal TinhPhuPhiQuaDem(DateTime thoiGianVao, DateTime thoiGianRa)
        {
            if (thoiGianRa.Date > thoiGianVao.Date)
            {
                return 30000m;
            }
            return 0m;
        }
    //Bài 14
    public static decimal TinhGiaGiam(string loaiKH, bool coTheSV, string ngayXem, decimal giaGoc)
        {
            string kh = loaiKH.Trim().ToLower();
            string ngay = ngayXem.Trim().ToLower();

            bool isCuoiTuan = (ngay == "friday" || ngay == "thứ 6" || 
                               ngay == "saturday" || ngay == "thứ 7" || 
                               ngay == "sunday" || ngay == "chủ nhật");

            if (kh == "child" || kh == "trẻ em" || kh == "senior" || kh == "người cao tuổi")
            {
                return giaGoc * 0.5m;
            }
            else if ((kh == "student" || kh == "sinh viên") && coTheSV && !isCuoiTuan)
            {
                return giaGoc * 0.3m;
            }
            else if ((ngay == "wednesday" || ngay == "thứ 4") && (kh == "adult" || kh == "người lớn"))
            {
                return giaGoc * 0.2m;
            }

            return 0m;
        }

        public static decimal TinhPhuThu(string ngayXem)
        {
            string ngay = ngayXem.Trim().ToLower();
            if (ngay == "friday" || ngay == "thứ 6" || 
                ngay == "saturday" || ngay == "thứ 7" || 
                ngay == "sunday" || ngay == "chủ nhật")
            {
                return 20000m;
            }
            return 0m;
        }

    static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ChayBai1();
            ChayBai2();
            ChayBai3();
            ChayBai4();
            ChayBai5();
            ChayBai6();
            ChayBai7();
            ChayBai8();
            ChayBai9();
            ChayBai10();
            ChayBai11();
            ChayBai12();
            ChayBai13();
            ChayBai15();

        }

        // ----------------------------------------------------
        // BÀI 1: TÍNH TIỀN ĐIỆN
        // ----------------------------------------------------
        static void ChayBai1()
        {
            Console.WriteLine("--- BÀI 1: TÍNH TIỀN ĐIỆN SINH HOẠT ---");
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal chiSoCu = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            decimal chiSoMoi = decimal.Parse(Console.ReadLine() ?? "0");

            if (chiSoMoi < chiSoCu)
            {
                Console.WriteLine("Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!\n");
                return;
            }

            decimal soKwh = chiSoMoi - chiSoCu;
            decimal tienChuaThue = Bai01_TinhTienDien.TinhTienChuaThue(soKwh);
            decimal thueVat = Bai01_TinhTienDien.TinhThueVat(tienChuaThue);
            decimal tongThanhToan = tienChuaThue + thueVat;

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Số điện tiêu thụ: {soKwh} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienChuaThue:#,##0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVat:#,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongThanhToan:#,##0} VNĐ\n");
        }

        // ----------------------------------------------------
        // BÀI 2: TÍNH BMI
        // ----------------------------------------------------
        static void ChayBai2()
        {
            Console.WriteLine("--- BÀI 2: HỆ THỐNG THEO DÕI CHỈ SỐ BMI ---");
            Console.Write("Chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine() ?? "0");

            double bmi = Bai02_TinhBMI.TinhBmi(chieuCao, canNang);
            string phanLoai = Bai02_TinhBMI.DanhGiaSuckhoe(bmi);
            double canMin = Bai02_TinhBMI.TinhCanNangToiThieu(chieuCao);
            double canMax = Bai02_TinhBMI.TinhCanNangToiDa(chieuCao);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khoẻ: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng từ {canMin:F2} kg đến {canMax:F2} kg\n");
        }

        // ----------------------------------------------------
        // BÀI 3: QUY ĐỔI NGOẠI TỆ
        // ----------------------------------------------------
        static void ChayBai3()
        {
            Console.WriteLine("--- BÀI 3: ỨNG DỤNG QUY ĐỔI NGOẠI TỆ ---");
            Console.Write("Nhập số tiền VNĐ: ");
            decimal vnd = decimal.Parse(Console.ReadLine() ?? "0");

            if (vnd <= 0)
            {
                Console.WriteLine("Lỗi: Số tiền VNĐ phải lớn hơn 0!\n");
                return;
            }

            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int loaiNgoaiTe = int.Parse(Console.ReadLine() ?? "0");

            decimal phiDichVu = Bai03_QuyDoiNgoaiTe.TinhPhiDichVu(vnd);
            decimal tienSauPhi = vnd - phiDichVu;
            decimal tienNhanDuoc = Bai03_QuyDoiNgoaiTe.TinhTienQuyDoi(tienSauPhi, loaiNgoaiTe);
            string tenNgoaiTe = Bai03_QuyDoiNgoaiTe.LayTenNgoaiTe(loaiNgoaiTe);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:#,##0.00} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {tienSauPhi:#,##0.00} VNĐ");
            Console.WriteLine($"Số tiền {tenNgoaiTe} nhận được: {tienNhanDuoc:#,##0.00} {tenNgoaiTe}\n");
        }

        // ----------------------------------------------------
        // BÀI 4: TÍNH TUỔI & ĐẾM NGƯỢC SINH NHẬT
        // ----------------------------------------------------
        static void ChayBai4()
        {
            Console.WriteLine("--- BÀI 4: TÍNH TUỔI & ĐẾM NGƯỢC SINH NHẬT ---");
            DateTime ngaySinh;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string input = Console.ReadLine() ?? "";
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                {
                    if (ngaySinh <= DateTime.Now) break;
                    Console.WriteLine("Ngày sinh không được vượt quá hiện tại!");
                }
                else
                {
                    Console.WriteLine("Lỗi định dạng dd/MM/yyyy, vui lòng nhập lại!");
                }
            }

            DateTime hienTai = DateTime.Now;
            int tuoi = Bai04_TinhTuoiSinhNhat.TinhTuoi(ngaySinh, hienTai);
            int soNgayDaSong = Bai04_TinhTuoiSinhNhat.TinhSoNgayDaSong(ngaySinh, hienTai);
            int soNgayDenSinhNhat = Bai04_TinhTuoiSinhNhat.TinhSoNgayConLaiDenSinhNhat(ngaySinh, hienTai);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Tuổi hiện tại: {tuoi}");
            Console.WriteLine($"Bạn đã sống tổng cộng: {soNgayDaSong} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayDenSinhNhat} ngày\n");
        }

        // ----------------------------------------------------
        // BÀI 5: QUẢN LÝ ĐIỂM HỌC PHẦN (GPA)
        // ----------------------------------------------------
        static void ChayBai5()
        {
            Console.WriteLine("--- BÀI 5: QUẢN LÝ ĐIỂM HỌC PHẦN & GPA ---");
            Console.Write("Điểm C# (4 TC): ");
            double csharp = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Điểm Toán (3 TC): ");
            double toan = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Điểm Tiếng Anh (2 TC): ");
            double tiengAnh = double.Parse(Console.ReadLine() ?? "0");

            double dtb = Bai05_QuanLyGpa.TinhDiemTrungBinh(csharp, toan, tiengAnh);
            string diemChu = Bai05_QuanLyGpa.QuyDoiDiemChu(dtb);
            double gpa = Bai05_QuanLyGpa.QuyDoiGpa(dtb);
            string hocLuc = Bai05_QuanLyGpa.XepLoaiHocLuc(dtb);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Điểm TB thang 10: {dtb:F2}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA thang 4: {gpa:F1}");
            Console.WriteLine($"Xếp loại học lực: {hocLuc}\n");
        }

        // ----------------------------------------------------
        // BÀI 6: CHUẨN HÓA HỌ TÊN & TẠO USERNAME
        // ----------------------------------------------------
        static void ChayBai6()
        {
            Console.WriteLine("--- BÀI 6: CHUẨN HÓA HỌ TÊN & TỰ ĐỘNG TẠO USERNAME ---");
            Console.Write("Nhập họ tên thô: ");
            string tenTho = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(tenTho))
            {
                Console.WriteLine("Chuỗi nhập vào rỗng!\n");
                return;
            }

            string hoTenChuan = Bai06_ChuanHoaHoTen.ChuanHoa(tenTho);
            string username = Bai06_ChuanHoaHoTen.TaoUsername(hoTenChuan);

            string[] tu = hoTenChuan.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string ho = tu[0];
            string ten = tu[tu.Length - 1];
            string tenDem = "";
            if (tu.Length > 2)
            {
                string[] mangDem = new string[tu.Length - 2];
                Array.Copy(tu, 1, mangDem, 0, tu.Length - 2);
                tenDem = string.Join(" ", mangDem);
            }

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Họ và tên chuẩn hoá: {hoTenChuan}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {username}@company.edu.vn\n");
        }

        // ----------------------------------------------------
        // BÀI 7: CHI PHÍ NHIÊN LIỆU (CAR-POOLING)
        // ----------------------------------------------------
        static void ChayBai7()
        {
            Console.WriteLine("--- BÀI 7: CHI PHÍ NHIÊN LIỆU & CAR-POOLING ---");
            Console.Write("Quãng đường (km): ");
            double khoangCach = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Mức tiêu hao (L/100km): ");
            double nhienLieu = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Giá xăng (VND/lít): ");
            decimal giaXang = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Số người đi: ");
            int soNguoi = int.Parse(Console.ReadLine() ?? "1");

            double tongLit = Bai07_ChiPhiNhienLieu.TinhTongLitXang(khoangCach, nhienLieu);
            decimal tongChiPhi = Bai07_ChiPhiNhienLieu.TinhTongChiPhi(tongLit, giaXang);
            decimal moiNguoi = Bai07_ChiPhiNhienLieu.TinhChiPhiMoiNguoi(tongChiPhi, soNguoi);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongLit:N2} lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VND");
            Console.WriteLine($"Chi phí mỗi người: {moiNguoi:N0} VND\n");
        }

        // ----------------------------------------------------
        // BÀI 8: XÁC THỰC OTP
        // ----------------------------------------------------
        static void ChayBai8()
        {
            Console.WriteLine("--- BÀI 8: HỆ THỐNG XÁC THỰC MÃ OTP ---");
            string systemOTP = "839201";

            Console.Write("Mã OTP nhận được: ");
            string inputOTP = (Console.ReadLine() ?? "").Trim();

            Console.Write("Thời gian trôi qua (giây): ");
            int secondPassed = int.Parse(Console.ReadLine() ?? "0");

            string ketQua = Bai08_XacThucOtp.KiemTraXacThuc(inputOTP, systemOTP, secondPassed);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine(ketQua + "\n");
        }

        // ----------------------------------------------------
        // BÀI 9: TÍNH LƯƠNG GROSS - NET
        // ----------------------------------------------------
        static void ChayBai9()
        {
            Console.WriteLine("--- BÀI 9: TÍNH LƯƠNG GROSS - NET ---");
            Console.Write("Lương Gross: ");
            decimal luongGross = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Số người phụ thuộc: ");
            int soNguoiPhuThuoc = int.Parse(Console.ReadLine() ?? "0");

            decimal baoHiem = Bai09_TinhLuongGrossNet.TinhBaoHiem(luongGross);
            decimal thuNhapChiuThue = Bai09_TinhLuongGrossNet.TinhThuNhapChiuThue(luongGross, baoHiem, soNguoiPhuThuoc);
            decimal thueTncn = Bai09_TinhLuongGrossNet.TinhThueTncn(thuNhapChiuThue);
            decimal luongNet = Bai09_TinhLuongGrossNet.TinhLuongNet(luongGross, baoHiem, thueTncn);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {baoHiem:N0} VNĐ");
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTncn:N0} VNĐ");
            Console.WriteLine($"Lương NET thực nhận: {luongNet:N0} VNĐ\n");
        }

        // ----------------------------------------------------
        // BÀI 10: QUẢN LÝ TỒN KHO (NULLABLE TYPES)
        // ----------------------------------------------------
        static void ChayBai10()
        {
            Console.WriteLine("--- BÀI 10: QUẢN LÝ TỒN KHO ---");
            string productId = "KB-09";
            string productName = "Bàn phím Cơ Akko";
            int? quantity = null;
            int minThreshold = 10;
            DateTime? restockDate = null;

            int displayQuantity = Bai10_QuanLyTonKho.LaySoLuongHienThi(quantity);
            string status = Bai10_QuanLyTonKho.TinhTrangThai(quantity, minThreshold);
            string restockText = Bai10_QuanLyTonKho.LayNgayRestock(restockDate);

            Console.WriteLine($"Sản phẩm: {productName} (Mã: {productId})");
            Console.WriteLine($"Số lượng tồn kho gốc: {(quantity.HasValue ? quantity.Value.ToString() : "null (Chưa kiểm kê)")}");
            Console.WriteLine($"Restock Date gốc: {(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Số lượng hiển thị: {displayQuantity} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");
            Console.WriteLine($"Trạng thái kho: {status}");
            Console.WriteLine($"Dự kiến nhập hàng: {restockText}\n");
        }

        // ----------------------------------------------------
        // BÀI 11: TÍNH LÃI SUẤT NGÂN HÀNG
        // ----------------------------------------------------
        static void ChayBai11()
        {
            Console.WriteLine("--- BÀI 11: TÍNH LÃI SUẤT NGÂN HÀNG ---");
            Console.Write("Số tiền gửi: ");
            decimal tienGui = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Lãi suất năm (%): ");
            double laiSuat = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Thời gian gửi (tháng): ");
            int kyHan = int.Parse(Console.ReadLine() ?? "0");

            decimal laiDon = Bai11_TinhLaiSuat.TinhLaiDon(tienGui, laiSuat, kyHan);
            decimal laiKep = Bai11_TinhLaiSuat.TinhLaiKep(tienGui, laiSuat, kyHan);
            string toiUu = Bai11_TinhLaiSuat.SoSanhLoiNhuan(laiDon, laiKep);
            decimal chenhLech = Math.Abs(laiDon - laiKep);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Tổng tiền lãi (lãi đơn): {laiDon:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {laiKep:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {chenhLech:N0} VNĐ {toiUu}\n");
        }

        // ----------------------------------------------------
        // BÀI 12: MÃ HÓA CAESAR
        // ----------------------------------------------------
        static void ChayBai12()
        {
            Console.WriteLine("--- BÀI 12: MÃ HÓA CAESAR ---");
            Console.Write("Văn bản gốc: ");
            string text = Console.ReadLine() ?? "";

            Console.Write("Khóa dịch chuyển k: ");
            int k = int.Parse(Console.ReadLine() ?? "0");

            string encrypted = Bai12_MaHoaCaesar.MaHoa(text, k);
            string decrypted = Bai12_MaHoaCaesar.GiaiMa(encrypted, k);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Văn bản Mã hóa: {encrypted}");
            Console.WriteLine($"Văn bản Giải mã: {decrypted}\n");
        }

        // ----------------------------------------------------
        // BÀI 13: TÍNH PHÍ ĐỖ XE
        // ----------------------------------------------------
        static void ChayBai13()
        {
            Console.WriteLine("--- BÀI 13: TÍNH PHÍ ĐỖ XE ---");
            Console.Write("Loại xe (Motorbike/Car/Truck): ");
            string loaiXe = Console.ReadLine() ?? "";

            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            DateTime gioVao = DateTime.ParseExact(Console.ReadLine() ?? "", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            DateTime gioRa = DateTime.ParseExact(Console.ReadLine() ?? "", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            if (gioRa < gioVao)
            {
                Console.WriteLine("Lỗi: Thời gian ra phải sau thời gian vào!\n");
                return;
            }

            double actualHours = (gioRa - gioVao).TotalHours;
            int totalHours = (int)Math.Ceiling(actualHours);

            decimal phi2GioDau = Bai13_TinhPhiDoXe.TinhPhi2GioDau(loaiXe);
            decimal giaGioSau = Bai13_TinhPhiDoXe.TinhPhiGioSau(loaiXe);
            decimal phiGioSau = totalHours > 2 ? (totalHours - 2) * giaGioSau : 0m;
            decimal phuPhi = Bai13_TinhPhiDoXe.TinhPhuPhiQuaDem(gioVao, gioRa);
            decimal tongPhi = phi2GioDau + phiGioSau + phuPhi;

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Tổng thời gian đỗ: {actualHours:F2} giờ -> Tính phí: {totalHours} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {phi2GioDau:N0} VNĐ");
            if (totalHours > 2)
            {
                Console.WriteLine($"Phí {totalHours - 2} giờ tiếp theo: {phiGioSau:N0} VNĐ");
            }
            if (phuPhi > 0)
            {
                Console.WriteLine($"Phụ phí qua đêm: {phuPhi:N0} VNĐ");
            }
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {tongPhi:N0} VNĐ\n");
        }

        // ----------------------------------------------------
        // BÀI 15: TÍNH GIÁ VÉ XEM PHIM
        // ----------------------------------------------------
        static void ChayBai15()
        {
            Console.WriteLine("--- BÀI 15: TÍNH GIÁ VÉ XEM PHIM ---");
            Console.Write("Khách hàng (Child/Student/Adult/Senior): ");
            string loaiKH = Console.ReadLine() ?? "";

            Console.Write("Có thẻ SV hợp lệ không (true/false): ");
            bool coTheSV = bool.Parse(Console.ReadLine() ?? "false");

            Console.Write("Ngày xem (Monday.../Thứ 2...): ");
            string ngayXem = Console.ReadLine() ?? "";

            decimal giaGoc = 100000m;
            decimal giaGiam = Bai15_GiaVeXemPhim.TinhGiaGiam(loaiKH, coTheSV, ngayXem, giaGoc);
            decimal phuThu = Bai15_GiaVeXemPhim.TinhPhuThu(ngayXem);
            decimal tongTien = giaGoc - giaGiam + phuThu;

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Giá vé gốc: {giaGoc:N0} VNĐ");
            Console.WriteLine($"Mức giảm giá: -{giaGiam:N0} VNĐ");
            Console.WriteLine($"Phụ thu cuối tuần: {phuThu:N0} VNĐ");
            Console.WriteLine($"Tổng tiền vé: {tongTien:N0} VNĐ\n");
        }
    }
}
