using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer
{
    public class TONGIAODLL
    {
        Quan_Ly_Nhan_SuEntities db = new Quan_Ly_Nhan_SuEntities();

        public TONGIAO getItem(int id)
        {
            return db.TONGIAOs.FirstOrDefault(X => X.ID == id);
        }

        public List<TONGIAO> getList()
        {
            return db.TONGIAOs.ToList();
        }
        public TONGIAO Add(TONGIAO tg)
        {
            try
            {
                db.TONGIAOs.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TONGIAO Update(TONGIAO tg)
        {
            try
            {
                var _tg = db.TONGIAOs.FirstOrDefault(X => X.ID == tg.ID);
                _tg.TENTG = tg.TENTG;
                db.SaveChanges();
                return _tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public TONGIAO Delete(int id)
        {
            try
            {
                var _tg = db.TONGIAOs.FirstOrDefault(X => X.ID == id);
                if ( _tg != null)
                {
                    db.TONGIAOs.Remove(_tg);
                    db.SaveChanges();
                }
                return _tg;
            }

            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
    }
}
