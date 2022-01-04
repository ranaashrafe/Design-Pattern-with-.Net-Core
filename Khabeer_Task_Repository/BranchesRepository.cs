using Khabeer_Task_Contract;
using Khabeer_Task_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khabeer_Task_Repository
{
    public class BranchesRepository : IBranchesRepository
    {
        private readonly Context _context;
        public BranchesRepository(Context context)
        {
            _context = context;

        }
        public async Task<Response> DeleteBranch(int UserId)
        {
            Response response = new Response();
            try
            {
                Users user = await GetUserDetailsById (UserId);
                if (user != null)
                {
                    _context.Remove<Users>(user);
                    _context.SaveChanges();
                    
                    response.Message = "User Deleted Successfully";
                }
                else
                {
                  
                    response.Message = "User Not Found";
                }
            }
            catch (Exception ex)
            {
              
                response.Message = "Error : " + ex.Message;
            }
            return response;
        }

        public async Task<Response> EditBranch(Users user)
        {
            Response response = new Response();
            try
            {
                var _User = await GetUserDetailsById(user.Id);
                if(_User !=null)
                {
                    _User.ArabicName = user.ArabicName;
                    _User.EnglishName = user.EnglishName;
                    _User.Address = user.Address;
                    _User.Maplng = user.Maplng;
                    _User.MapLat = user.MapLat;
                     _context.Update<Users>(_User);

                    _context.SaveChanges();
                    response.Message = "User Inserted";
                }
                else { response.Message = "User Not Found"; }
                
            }
            catch (Exception)
            {
                response.Message = "User Not Updated";
            }
            return response;
        }


        public async Task<Users> GetUserDetailsById(int UserId)
        {
            Users _User;
            try
            {
                _User = _context.Find<Users>(UserId);
            }
            catch (Exception)
            {
                throw;
            }
            return _User;
        }

        public async Task<List<Users>> GetBranchesTable()
        {
            List<Users> users;
            try
            {
                users = await _context.Set<Users>().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return users;
        }

        public async Task<Response> InsertnewBranch(Users user)
        {
            Response response = new Response();
            try
            {
              await  _context.AddAsync<Users>(user);
                _context.SaveChanges();
                response.Message = "User Inserted";
            }
            catch(Exception)
            {
                response.Message = "User Not Inserted";
            }
            return response;
        }
    }
}
