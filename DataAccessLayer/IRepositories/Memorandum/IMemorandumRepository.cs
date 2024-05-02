using DataAccessLayer.Contacts.Common;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories.Memorandum
{
    public interface IMemorandumRepository:IRepository<Homemo>
    {
        List<MemorandumVM> GetMemorandum();
    }
}
