﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        //public CustomersController(ApplicationDbContext context)
        public CustomersController(IUnitOfWork unitofWork)
        {
            //_context = context;
            _unitOfWork = unitofWork;
        }

        // GET: api/Customers
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Model>>> GetCustomers()
        public async Task<ActionResult> GetCustomers()
        {
            //return await _context.Customers.ToListAsync();
            var Customers = await _unitOfWork.Customers.GetAll();
            return Ok(Customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Model>> GetCustomer(int id)
        public async Task<ActionResult> GetCustomers(int id)
        {
            //var Model = await _context.Customers.FindAsync(id);
            var Customer = await _unitOfWork.Customers.Get(q=> q.Id ==id);

            if (Customer == null)
            {
                return NotFound();
            }

            //return Model;
            return Ok(Customer);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer Customer)
        {
            if (id != Customer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Model).State = EntityState.Modified;
            _unitOfWork.Customers.Update(Customer);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CustomerExists(id))
                if (!await CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostCustomer(Customer Customer)
        {
            //_context.Customers.Add(Model);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Insert(Customer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCustomer", new { id = Customer.Id }, Customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            //var Model = await _context.Customers.FindAsync(id);
            var Customer = await _unitOfWork.Customers.Get(q=>q.Id ==id);
            if (Customer == null)
            {
                return NotFound();
            }

            //_context.Customers.Remove(Model);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            //return _context.Customers.Any(e => e.Id == id);
            var Customer = await _unitOfWork.Customers.Get(q=>q.Id ==id);
            return Customer != null;
        }
    }
}
