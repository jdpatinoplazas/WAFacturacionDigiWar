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
    public class RepositoryFactura : IRepository<Factura>
    {
        ApplicationDbContext _dbContext;
        public RepositoryFactura(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Factura> Create(Factura _object)
        {
            var obj = await _dbContext.Facturas.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(Factura _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Factura> GetAll()
        {
            try
            {
                return _dbContext.Facturas.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Factura GetById(int Id)
        {
            return _dbContext.Facturas.Where(x => x.idFactura == Id).FirstOrDefault();
        }

        public void Update(Factura _object)
        {
            _dbContext.Facturas.Update(_object);
            _dbContext.SaveChanges();
        }
    }
}
