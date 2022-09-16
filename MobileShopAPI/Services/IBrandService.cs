using MobileShopAPI.Model;

namespace MobileShopAPI.Services
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAllBrands();
        Brand GetBrandById(int? id);
        int AddBrand(Brand brand);
        int UpdateBrand(Brand brand);
        int DeleteBrand(int? id);
    }
}
