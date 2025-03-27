using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DANTOCDLL
    {
        Quan_Ly_Nhan_SuEntities db = new Quan_Ly_Nhan_SuEntities();

        public DANTOC getItem(int id)
        {
            return db.DANTOCs.FirstOrDefault(X => X.ID == id);
        }

        public List<DANTOC> getList()
        {
            return db.DANTOCs.ToList();
        }
        public DANTOC Add(DANTOC dt)
        {
            try
            {
                db.DANTOCs.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public DANTOC Update(DANTOC dt)
        {
            try
            {
                var _dt = db.DANTOCs.FirstOrDefault(X => X.ID == dt.ID);
                _dt.TENDT = dt.TENDT;
                db.SaveChanges();
                return _dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
        public DANTOC Delete(int id)
        {
            try
            {
                var _dt = db.DANTOCs.FirstOrDefault(X => X.ID == id);
                if (_dt != null)
                {
                    db.DANTOCs.Remove(_dt);
                    db.SaveChanges();
                }
                return _dt;
            }
           

            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }
    }
}
