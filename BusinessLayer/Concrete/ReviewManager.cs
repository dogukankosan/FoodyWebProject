using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDal _reviewDal;
        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }
        public void TDelete(int id)
        {
            _reviewDal.Delete(id);
        }
        public List<Review> TGetAll()
        {
            return _reviewDal.GetAll();
        }
        public Review TGetByID(int id)
        {
            return _reviewDal.GetByID(id);
        }
        public void TInsert(Review entity)
        {
            _reviewDal.Insert(entity);
        }
        public void TUpdate(Review entity)
        {
            _reviewDal.Update(entity);
        }
    }
}