using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class KhuDat:DiaOc
    {
        private string _loai = "KhuDat";

        public override string Loai { get => _loai; set => _loai = value; }
    }
}
