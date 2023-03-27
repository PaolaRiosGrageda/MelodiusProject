using MelodiusDataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Interface
{
    public interface IUserService
    {
        public List<UserDto> GetAll();
        public UserDto GetById(int id);
        public int AddNew(UserDto userDto);
        public int Update(UserDto userDto);
        public int Delete(int id);
    }
}
