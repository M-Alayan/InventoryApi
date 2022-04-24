using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniss_Logic.SpecificRepository
{
    public interface IBrandService
    {

        void insert(Brand brand);

        void delete(int id);
        void update(Brand brand);
        List<Brand> librand();
        Brand edit(int id);
        List<Brand> search(string name);
        List<Brand> liActiveBrand();
    }
}
