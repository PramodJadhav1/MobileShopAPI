using MobileShopAPI.Entities;
using MobileShopAPI.Model;

namespace MobileShopAPI.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _context;
        public BrandRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddBrand(Brand brand)
        {
            _context.Brand.Add(brand);
            int result = _context.SaveChanges();
            return result;
        }

        public int DeleteBrand(int? id)
        {
            int res = 0;
            Brand b = _context.Brand.Where(x => x.Id == id).FirstOrDefault();
            if (b != null)
            {
                _context.Brand.Remove(b);
                res = _context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _context.Brand.ToList();
        }
        public Brand GetBrandById(int? id)
        {
            Brand b = _context.Brand.Find(id);
            return b;
        }

        public int UpdateBrand(Brand brand)
        {
            int res = 0;
            Brand b = _context.Brand.Where(x => x.Id == brand.Id).FirstOrDefault();
            if (b != null)
            {
                b.MName = brand.MName;
                b.ModelNo = brand.ModelNo;
                b.Price = brand.Price;
                res = _context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }

    }
}
