using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khabeer_Task_Contract
{
    public interface IRepositoryManager
    {
        public IBranchesRepository UserRepository { get; }
    }
}
