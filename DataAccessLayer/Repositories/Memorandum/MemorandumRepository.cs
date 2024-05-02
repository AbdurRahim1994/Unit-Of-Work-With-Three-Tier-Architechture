using DataAccessLayer.Data;
using DataAccessLayer.IRepositories.Memorandum;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.Common;
using DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Memorandum
{
    public class MemorandumRepository : Repository<Homemo>, IMemorandumRepository
    {
        private readonly MemorandumDbContext _context;
        public MemorandumRepository(MemorandumDbContext context) : base(context)
        {
            _context = context;
        }
        public List<MemorandumVM> GetMemorandum()
        {
            var result = (from hm in _context.Homemos
                          select new MemorandumVM
                          {
                              HomemoId = hm.HomemoId,
                              BranchCode = hm.BranchCode,
                              TrDate = hm.TrDate,
                              TrMonth = hm.TrMonth,
                              TrYear = hm.TrYear,
                              TrAmount = hm.TrAmount,
                              Accode = hm.Accode,
                              MemoDesc = hm.MemoDesc,
                              Remarks = hm.Remarks
                          }).ToList();
            return result;
        }
    }
}
