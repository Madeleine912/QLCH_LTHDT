using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH_LTHDT_Entities;
using QLCH_LTHDT_Services;

namespace QLCH_LTHDT_WEB.Pages
{
    public class MH_Danhsach_SanphamModel : PageModel
    {
        private ITXulysanpham _xulysanpham = new Xulysanpham();
        public List<Sanpham> Danhsachsanpham;
        public string Chuoi = string.Empty;
        [BindProperty]
        public string tukhoa { get; set; }
        public void OnGet()
        {
            Danhsachsanpham = _xulysanpham.Docdanhsachsanpham();
        }

        public void OnPost()
        {
            Danhsachsanpham = _xulysanpham.Docdanhsachsanpham(tukhoa);
        }
    }
}
