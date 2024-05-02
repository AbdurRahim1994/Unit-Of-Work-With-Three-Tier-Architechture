using BusinessAccessLayer.Interface.Memorandum;
using BusinessAccessLayer.Services.Memorandum;
using BusinessAccessLayer.UnitOfWork.Interface;
using DataAccessLayer.Data;
using DataAccessLayer.IRepositories.Memorandum;
using DataAccessLayer.Repositories.Memorandum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.UnitOfWork.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MemorandumDbContext _context;
        public UnitOfWork(/*MemorandumDbContext context*/)
        {
            _context = new MemorandumDbContext();
            //_context = context;
            MemorandumService = new MemorandumService(_context);
            MemorandumRepository=new MemorandumRepository(_context);
        }
        public IMemorandumService MemorandumService { get; private set; }
        public IMemorandumRepository MemorandumRepository { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
