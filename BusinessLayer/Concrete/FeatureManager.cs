using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public void TDelete(int id)
        {
            _featureDal.Delete(id);
        }
        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }
        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }
        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }
        public void TUpdate(Feature entity)
        {
           _featureDal.Update(entity);
        }
    }
}