using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH_LTHDT_Entities;
using QLCH_LTHDT_Services;
using System.Reflection;

namespace QLCH_LTHDT_WEB.Pages
{
    public class MH_Xoa_SanphamModel : PageModel

    {
        [BindProperty]
        public int masp { get; set; }

        public string Chuoi { get; set; } = string.Empty;
        private ITXulysanpham _xulysanpham = new Xulysanpham();


        public void OnGet()
        {

        }
        public void OnPost()
        {

            try
           
                {
                    var spxoa = new Sanpham(masp.ToString());

                    _xulysanpham.Xoasanpham(spxoa);
                    Response.Redirect("/MH_Danhsach_Sanpham");
                }
            

            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }




        }
    }
}



