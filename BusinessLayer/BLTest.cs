﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BLTest
    {
        DLTest BLtest = new  DLTest();
        public DataTable BLtb()
        {
            return BLtest.tbTest();
        }
    }
}
