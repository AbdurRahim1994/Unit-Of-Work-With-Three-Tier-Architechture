using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Contacts.Common;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModel;

namespace BusinessAccessLayer.Interface.Memorandum
{
    public interface IMemorandumService : IRepository<Homemo>
    {
        List<MemorandumVM> GetMemorandum();
    }
}
