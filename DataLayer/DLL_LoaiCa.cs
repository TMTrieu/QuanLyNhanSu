using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public partial class DLL_LoaiCa
    {
        QuanLyNhanSuContext _db;
        public  DLL_LoaiCa()
        {
            _db = new QuanLyNhanSuContext();
        }


        public LOAICA getItem(int idloaica)
        {
            return _db.LOAICAs.FirstOrDefault(x => x.IDLOAICA == idloaica);

        }

        public List<LOAICA> getList()
        {
            return _db.LOAICAs.ToList();
        }

        public LOAICA Add(LOAICA lc)
        {
            try
            {
                _db.LOAICAs.Add(lc);
                _db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public LOAICA Update(LOAICA lc)
        {
            try
            {
                var a = _db.LOAICAs.FirstOrDefault(x => x.IDLOAICA == lc.IDLOAICA);
                a.TENLOAICA = lc.TENLOAICA;
                a.HESO = lc.HESO;

                _db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int idloaica)
        {
            try
            {
                var lc = _db.LOAICAs.FirstOrDefault(x=>x.IDLOAICA==idloaica);
               

               _db.LOAICAs.Remove(lc);
                _db.SaveChanges();
                
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
