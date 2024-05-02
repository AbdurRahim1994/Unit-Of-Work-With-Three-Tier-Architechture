using BusinessAccessLayer.Interface.Memorandum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.UnitOfWork.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        IMemorandumService MemorandumService { get; }
        void Save();
    }
}
