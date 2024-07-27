using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal_;
        public ProductManager(IProductDal productDal_)
        {
            _productDal_ = productDal_;
        }
        public void TDelete(int id)
        {
            _productDal_.Delete(id);
        }
        public List<Product> TGetAll()
        {
            return _productDal_.GetAll();
        }
        public Product TGetByID(int id)
        {
            return _productDal_.GetByID(id);
        }
        public void TInsert(Product entity)
        {
            _productDal_.Insert(entity);
        }
        public void TUpdate(Product entity)
        {
            _productDal_.Update(entity);
        }
    }
}