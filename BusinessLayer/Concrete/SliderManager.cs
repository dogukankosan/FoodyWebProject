using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }
        public void TDelete(int id)
        {
            _sliderDal.Delete(id);
        }
        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }
        public Slider TGetByID(int id)
        {
            return _sliderDal.GetByID(id);
        }
        public void TInsert(Slider entity)
        {
            _sliderDal.Insert(entity);
        }
        public void TUpdate(Slider entity)
        {
            _sliderDal.Update(entity);
        }
    }
}