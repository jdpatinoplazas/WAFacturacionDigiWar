using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_FACTURA.Data;
using DAL_FACTURA.Interface;
using DAL_FACTURA.Models;

namespace DAL_FACTURA.Repository
{
    public class RepositoryProducto : IRepository<Producto>
    {
        ApplicationDbContext _dbContext;
        public RepositoryProducto(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Producto> Create(Producto _object)
        {
            var obj = await _dbContext.Productos.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(Producto _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Producto> GetAll()
        {
            try
            {
                return _dbContext.Productos.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Producto GetById(int Id)
        {
            return _dbContext.Productos.Where(x => x.idProducto == Id).FirstOrDefault();
        }

        public void Update(Producto _object)
        {
            _dbContext.Productos.Update(_object);
            _dbContext.SaveChanges();
        }
    }
}
