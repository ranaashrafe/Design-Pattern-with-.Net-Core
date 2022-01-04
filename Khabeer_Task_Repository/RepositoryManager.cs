using Khabeer_Task_Contract;
using Khabeer_Task_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khabeer_Task_Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Context _context;
        private BranchesRepository _UserRepository;
        public RepositoryManager(Context context)
        {
            _context = context;

        }
        public IBranchesRepository  UserRepository
        {
            get
            {
                if (_UserRepository == null)
                    _UserRepository = new BranchesRepository(_context);
                return _UserRepository;
            }
        }
    }
}
