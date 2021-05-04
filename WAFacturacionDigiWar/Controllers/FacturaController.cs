using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BAL_FACTURA.Service;
using DAL_FACTURA.Interface;
using DAL_FACTURA.Models;

namespace WAFacturacionDigiWar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly FacturaService _facturaService;

        private readonly IRepository<Factura> _Factura;

        public FacturaController(IRepository<Factura> Factura, FacturaService facService)
        {
            _facturaService = facService;
            _Factura = Factura;

        }
        //Add Factura  
        [HttpPost("AddFactura")]
        public async Task<Object> AddFactura([FromBody] Factura factura)
        {
            try
            {
                await _facturaService.AddFactura(factura);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Factura  
        [HttpDelete("DeleteFactura")]
        public bool DeleteFactura(int idVenta)
        {
            try
            {
                _facturaService.DeleteFactura(idVenta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Delete Factura  
        [HttpPut("UpdateFactura")]
        public bool UpdateFactura(Factura Object)
        {
            try
            {
                _facturaService.UpdateFactura(Object);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //GET All factura by idventa  
        [HttpGet("GetAllFacturaByIdVenta")]
        public Object GetAllFacturaByIdVenta(int idVenta)
        {
            var data = _facturaService.GetFacturaByIdVenta(idVenta);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        //GET All Facturas  
        [HttpGet("GetAllFacturas")]
        public Object GetAllFacturas()
        {
            var data = _facturaService.GetAllFacturas();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
    }
}
