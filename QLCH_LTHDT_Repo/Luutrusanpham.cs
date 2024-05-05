using QLCH_LTHDT_Entities;

namespace QLCH_LTHDT_Repo
{
    public class Luutrusanpham : ITLuutrusanpham

    {
        private string _filePath = "D:\\IT learning\\LTHDT\\QLCH_LTHDT\\QLCH_LTHDT\\dssp.txt";
        public List<Sanpham> Docdanhsachsanpham()
        {
        List <Sanpham> dssanpham = new List<Sanpham>();
        StreamReader file = new StreamReader(_filePath);
        int n;
        string s = file.ReadLine();
        n = int.Parse(s);
            for (int i = 0; i<n; i++)
            {
                s = file.ReadLine();
                dssanpham.Add(new Sanpham(s));
      
              }
            file.Close();

            return dssanpham;
            }
        public void Luudanhsachsanpham(List<Sanpham> dssanpham)
        {
           
            StreamWriter file = new StreamWriter(_filePath);
            file.WriteLine(dssanpham.Count);
           foreach (var sp in dssanpham) 
            {
                file.WriteLine($"{sp.Masanpham},{sp.Tensanpham},{sp.Hsd},{sp.Congtysanxuat},{sp.Ngaysanxuat},{sp.Loaihang},{sp.Gia}");

            }
            file.Close();
        }
        public void Themsanpham(Sanpham sanpham)
        {
            var dssp = Docdanhsachsanpham();
            dssp.Add(sanpham);
            Luudanhsachsanpham(dssp);
        }
        }

    }
