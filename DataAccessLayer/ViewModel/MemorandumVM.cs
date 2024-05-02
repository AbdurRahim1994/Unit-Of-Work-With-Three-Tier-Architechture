using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModel
{
    public class MemorandumVM
    {
        public int HomemoId { get; set; }

        public string BranchCode { get; set; } = null!;

        public DateTime? TrDate { get; set; }

        public byte? TrMonth { get; set; }

        public short? TrYear { get; set; }

        public string MemoDesc { get; set; } = null!;

        public double? TrAmount { get; set; }

        public string? Accode { get; set; }

        public string Remarks { get; set; } = null!;
    }
}
