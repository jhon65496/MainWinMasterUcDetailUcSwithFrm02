using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainWinMasterUcDetailUcSwithFrm02.Data;
using MainWinMasterUcDetailUcSwithFrm02.Models;

namespace MainWinMasterUcDetailUcSwithFrm02.Repositories
{
    public class GroupsRepository
    {
        TestDataContext dataContext;

        public GroupsRepository()
        {
          dataContext = new TestDataContext();
        }


        public IEnumerable<Group> GetAll()
        {
            return dataContext.Groups.AsEnumerable<Group>();
        }
    }
}
