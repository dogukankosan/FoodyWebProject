using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }
        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();
        }
        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }
        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }
        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}