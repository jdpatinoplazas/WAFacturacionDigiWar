using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_FACTURA.Interface;
using DAL_FACTURA.Models;

namespace BAL_FACTURA.Service
{
    public class FacturaService
    {
        private readonly IRepository<Factura> _factura;

        public FacturaService(IRepository<Factura> factura)
        {
            _factura = factura;
        }
        //Get Factura By Venta Id  
        public IEnumerable<Factura> GetFacturaByIdVenta(int idVenta)
        {
            return _factura.GetAll().Where(x => x.idVenta == idVenta).ToList();
        }
        //GET All Facturas   
        public IEnumerable<Factura> GetAllFacturas()
        {
            try
            {
                return _factura.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Add Factura  
        public async Task<Factura> AddFactura(Factura factura)
        {
            return await _factura.Create(factura);
        }
        //Delete Factura   
        public bool DeleteFactura(int idVenta)
        {

            try
            {
                var DataList = _factura.GetAll().Where(x => x.idVenta == idVenta).ToList();
                foreach (var item in DataList)
                {
                    _factura.Delete(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }
        //Update Factura  
        public bool UpdateFactura(Factura factura)
        {
            try
            {
                var DataList = _factura.GetAll().ToList();
                foreach (var item in DataList)
                {
                    _factura.Update(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
