using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public void TDelete(int id)
        {
            _addressDal.Delete(id);
        }
        public List<Address> TGetAll()
        {
            return _addressDal.GetAll();
        }
        public Address TGetByID(int id)
        {
            return _addressDal.GetByID(id);
        }
        public void TInsert(Address entity)
        {
            _addressDal.Insert(entity);
        }
        public void TUpdate(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}