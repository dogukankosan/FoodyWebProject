using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class SocialMedia : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public SocialMedia(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void TDelete(int id)
        {
            _socialMediaDal.Delete(id);
        }
        public List<EntityLayer.Concrete.SocialMedia> TGetAll()
        {
            return _socialMediaDal.GetAll();
        }
        public EntityLayer.Concrete.SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }
        public void TInsert(EntityLayer.Concrete.SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }
        public void TUpdate(EntityLayer.Concrete.SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}