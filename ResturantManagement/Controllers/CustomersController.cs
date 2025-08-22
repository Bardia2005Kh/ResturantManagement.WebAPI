using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResturantManagement.Data;
using ResturantManagement.Models.DTOs.CustomerDTOs;
using ResturantManagement.Models.Entities;
using ResturantManagement.Repository.Interfaces;

namespace ResturantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ResturantDbContext resturantDbContext;
        private readonly IMapper mapper;
        private readonly ICustomerRepository customerRepository;

        public CustomersController(ResturantDbContext resturantDbContext, IMapper mapper, ICustomerRepository customerRepository)
        {
            this.resturantDbContext = resturantDbContext;
            this.mapper = mapper;
            this.customerRepository = customerRepository;
        }

        // GET ALL
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customerDomain = await customerRepository.GrtAllAsync();

            var customerDto = mapper.Map<List<CustomerDto>>(customerDomain);

            return Ok(customerDto);

        }

        // GET BY ID
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var customerDomain = await customerRepository.GetByIdAsync(id);
            if (customerDomain == null)
            {
                return NotFound();
            }
            var customerDto = mapper.Map<CustomerDto>(customerDomain);
            return Ok(customerDto);
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCustomerDto addCustomerDto)
        {
            var customerDomain = mapper.Map<Customer>(addCustomerDto);

            customerDomain = await customerRepository.CreateAsync(customerDomain);

            var customerDto = mapper.Map<CustomerDto>(customerDomain);

            return Ok(customerDto);

        }

        // PUT
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(int id, UpdateCustomerDto updateCustomerDto)
        {
            var customerDomain = mapper.Map<Customer>(updateCustomerDto);

            customerDomain = await customerRepository.UpdateAsync(id, customerDomain);
            if (customerDomain == null)
            {
                return NotFound();
            }

            var customerDto = mapper.Map<CustomerDto>(customerDomain);

            return Ok(customerDto);
        }

        // DELETE
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var customerDomain = await customerRepository.DeleteAsync(id);
            if (customerDomain == null)
            {
                return NotFound();
            }
            var customerDto = mapper.Map<CustomerDto>(customerDomain);
            return Ok(customerDto);
        }

        
    }
}
