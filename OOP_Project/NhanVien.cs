using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    abstract class NhanVien
    {

        public DateTime NgayBatDauLam { get; set; }
        public abstract int LuongCoBan();
    }
}
