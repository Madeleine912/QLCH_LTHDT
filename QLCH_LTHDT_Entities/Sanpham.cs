namespace QLCH_LTHDT_Entities
{
    public class Sanpham
    {
        public int Masanpham { get; set; }
        public string Tensanpham { get; set; }

        public string Hsd { get; set; }

        public string Congtysanxuat { get; set; }

        public string Ngaysanxuat { get; set; }

        public string Loaihang { get; set; }

        public int Gia { get; set; }



        public Sanpham( string tensp, string hsd, string ctsx, string nsx, string lh, int gia)
        {

            Tensanpham = tensp;
            Hsd = hsd;
            Congtysanxuat = ctsx;
            Ngaysanxuat = nsx;
            Loaihang = lh;
            Gia = gia;
        }
        public Sanpham(string s)
        {
            string[] m = s.Split(',');
            Masanpham = int.Parse(m[0]);    
            Tensanpham = m[1];
            Hsd = m[2];
            Congtysanxuat = m[3];
            Ngaysanxuat = m[4];
            Loaihang = m[5];
            Gia = int.Parse(m[6]);
        }
    }
}