using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class BLLPhongBan
    {
        Quan_Ly_Nhan_SuContext db = new Quan_Ly_Nhan_SuContext();

        public PHONGBAN getItem(int id)
        {
            return db.PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }
        public List<PHONGBAN> getList()
        {
            return db.PHONGBAN.ToList();
        }
        public PHONGBAN Add(PHONGBAN dt)
        {
            try
            {
                db.PHONGBAN.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public PHONGBAN Update(PHONGBAN dt)
        {
            try
            {
                var _dt = db.PHONGBAN.FirstOrDefault(x => x.IDPB == dt.IDPB);
                _dt.TENPB = dt.TENPB;
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _dt = db.PHONGBAN.FirstOrDefault(x => x.IDPB == id);
                db.PHONGBAN.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
