using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH_LTHDT_Entities;
using QLCH_LTHDT_Services;

namespace QLCH_LTHDT_WEB.Pages
{
    public class MH_Them_SanphamModel : PageModel

    {

        [BindProperty]
        public string Tensanpham { get; set; }

        [BindProperty]
        public string Hsd { get; set; }

        [BindProperty]
        public string Congtysanxuat { get; set; }

        [BindProperty]
        public string Ngaysanxuat { get; set; }

        [BindProperty]
        public string Loaihang { get; set; }

        [BindProperty]
        public int Gia { get; set; }

        public string Chuoi { get; set; } = string.Empty;
        private ITXulysanpham _xulysanpham = new Xulysanpham();
        public void OnGet()
        {
        }
        public void OnPost()
        {

            if (string.IsNullOrEmpty(Tensanpham))
            {
                Chuoi = "Tên không được để trống";
            }
            if (string.IsNullOrEmpty(Hsd))
            {
                Chuoi = "Hạn sử dụng không được để trống";
            }
            if (string.IsNullOrEmpty(Congtysanxuat))
            {
                Chuoi = "Công ty sản xuất  không được để trống";
            }
            if (string.IsNullOrEmpty(Ngaysanxuat))
            {
                Chuoi = "Ngày sản xuất không được để trống";
            }
            if (string.IsNullOrEmpty(Loaihang))
            {
                Chuoi = "Loại hàng không được để trống";
            }
            if (Gia<0)
            {
                Chuoi += "Giá không hợp lệ";
            }

            if (Chuoi == string.Empty)
            {
                var sp = new Sanpham(Tensanpham, Hsd, Congtysanxuat, Ngaysanxuat, Loaihang, Gia);
                //sp.Hsd = Hsd;
                //sp.Congtysanxuat = Congtysanxuat;
                //sp.Ngaysanxuat = Ngaysanxuat;
                //sp.Loaihang = Loaihang;
                //sp.Gia = Gia;

                _xulysanpham.Themsanpham(sp);
                Response.Redirect("/MH_Danhsach_Sanpham");
            }
        }
    }
}
