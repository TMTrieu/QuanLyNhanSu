using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public partial class BLL_LoaiCa
    {
        private DLL_LoaiCa dalLoaiCa;
        public BLL_LoaiCa()
        {
            dalLoaiCa = new DLL_LoaiCa();
        }

        public DTO_LoaiCa GetList()
        {
            return dalLoaiCa.getList();
            //return dalLoaiCa.getList().Select().ToList();
        }


        public LOAICA GetItem(int id)
        {
            return dalLoaiCa.getItem(id);
        }

        public LOAICA Add(LOAICA lc)
        {
            // Thêm logic nghiệp vụ nếu cần
            return dalLoaiCa.Add(lc);
        }

        public LOAICA Update(LOAICA lc)
        {
            // Thêm logic nghiệp vụ nếu cần
            return dalLoaiCa.Update(lc);
        }

        public void Delete(int id)
        {
            dalLoaiCa.Delete(id);
        }
    }
}
