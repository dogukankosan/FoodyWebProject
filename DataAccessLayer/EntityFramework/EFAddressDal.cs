using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFAddressDal : GenericRepository<Address>, IAddressDal
    {
        public EFAddressDal(Context.Context context) : base(context)
        {
        }
    }
}