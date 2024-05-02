using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAccessLayer.Interface.Memorandum;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.Common;
using DataAccessLayer.ViewModel;
using DataAccessLayer.IRepositories.Memorandum;

namespace BusinessAccessLayer.Services.Memorandum
{
    public class MemorandumService : Repository<Homemo>, IMemorandumService
    {
        private readonly IMemorandumRepository _memorandumRepository;

        public MemorandumService(MemorandumDbContext _context) : base(_context)
        {
        }

        public MemorandumService(MemorandumDbContext context, IMemorandumRepository memorandumRepository) : base(context)
        {
            _memorandumRepository = memorandumRepository;
        }

        public List<MemorandumVM> GetMemorandum()
        {
            return _memorandumRepository.GetMemorandum();
        }
    }
}
