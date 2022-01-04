using Khabeer_Task_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khabeer_Task_Contract
{
    public interface IBranchesRepository
    {
        public Task<List<Users>> GetBranchesTable();
        public Task<Response> InsertnewBranch(Users user);    
        public Task<Response> EditBranch(Users user); 
        public Task<Response> DeleteBranch(int UserId);
    }
}
