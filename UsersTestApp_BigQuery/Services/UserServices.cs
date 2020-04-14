using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersTestApp_BigQuery.Entities;
using UsersTestApp_BigQuery.Repository;

namespace UsersTestApp_BigQuery.Services
{
    public class UserServices
    {
        UserRepository userRepository = new UserRepository();
        public async Task<bool> addUsers(List<User> users)
        {
            return await userRepository.addUsers(users);
        }
        public async Task<bool> selectUsers()
        {
            return await userRepository.selectUsers();
        }
        public async Task<bool> selectReplaceUsers()
        {
            return await userRepository.selectReplaceUsers();
        }
        public async Task<bool> selectExceptUsers()
        {
            return await userRepository.selectExceptUsers();
        }
        public async Task<bool> selectLimitUsers()
        {
            return await userRepository.selectLimitUsers();
        }
        public async Task<bool> selectSampleUsers()
        {
            return await userRepository.selectSampleUsers();
        }
        public async Task<bool> selectQualifyUsers()
        {
            return await userRepository.selectQualifyUsers();
        }
        public async Task<bool> selectNotEqualUsers()
        {
            return await userRepository.selectNotEqualUsers();
        }
    }
}
