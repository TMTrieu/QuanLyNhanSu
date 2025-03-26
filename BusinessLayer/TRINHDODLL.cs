using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class TRINHDODLL
    {

        Quan_Ly_Nhan_SuEntities db = new Quan_Ly_Nhan_SuEntities();

        public TRINH_DO getItem(int id)
        {
            return db.TRINH_DOes.FirstOrDefault(X => X.IDTD == id);
        }

        public List<TRINH_DO> getList()
        {
            return db.TRINH_DOes.ToList();
        }
        public TRINH_DO Add(TRINH_DO td)
        {
            try
            {
                db.TRINH_DOes.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TRINH_DO Update(TRINH_DO td)
        {
            try
            {
                var _td = db.TRINH_DOes.FirstOrDefault(X => X.IDTD == td.IDTD);
                _td.TENTD = td.TENTD;
                db.SaveChanges();
                return _td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public TRINH_DO Delete(int id)
        {
            try
            {
                var _td = db.TRINH_DOes.FirstOrDefault(X => X.IDTD == id);
                if (_td != null)
                {
                    db.TRINH_DOes.Remove(_td);
                    db.SaveChanges();
                }
                return _td;
            }

            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }

    }
}

