using HospitalManager.API.Services;
using HospitalManager.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers
{
    [ApiController]
    [Route("api/address")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            this._addressService = addressService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {
            try
            {
                var address = await this._addressService.GetById(id);
                return Ok(address);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAddresses()
        {
            try
            {
                var addresses = await this._addressService.GetAll();
                return Ok(addresses);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            try
            {
                await this._addressService.Delete(id);
                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] AddressDTO addressDTO)
        {
            try
            {
                var updatedAddress = await this._addressService.Update(id, addressDTO);
                return Ok(updatedAddress);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress([FromBody] AddressDTO addressDTO)
        {
            try
            {
                await this._addressService.Add(addressDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $" Internal server error: {ex.Message}");
            }
        }
    }
}
