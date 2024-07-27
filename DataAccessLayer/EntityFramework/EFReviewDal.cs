using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFReviewDal : GenericRepository<Review>, IReviewDal
    {
        public EFReviewDal(Context.Context context) : base(context)
        {
        }
    }
}