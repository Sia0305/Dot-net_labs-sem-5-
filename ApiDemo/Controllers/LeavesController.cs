using ApiDemo.Models;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiDemo.DTO;
using ApiDemo.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IValidator<CreateLeaveDTO> _createValidator;
        private readonly IValidator<LeaveDTO> _validator;

        public LeavesController(AppDbContext context, IValidator<CreateLeaveDTO> createValidator, IValidator<LeaveDTO> validator)
        {
            _context = context;
            _createValidator = createValidator;
            _validator = validator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _context.Leaves.ToListAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateLeaveDTO leaveDto)
        {
            var validationResult = await _createValidator.ValidateAsync(leaveDto);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            var leaveModel = new LeaveModel
            {
                EmployeeId = leaveDto.EmployeeId,
                EmployeeName = leaveDto.EmployeeName,
                LeaveType = leaveDto.LeaveType,
                FromDate = leaveDto.FromDate,
                ToDate = leaveDto.ToDate,
                TotalLeaveDuration = leaveDto.TotalLeaveDuration,
                Reason = leaveDto.Reason
            };
            _context.Leaves.Add(leaveModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = leaveModel.LeaveId }, leaveModel);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] LeaveDTO leaveDto)
        {
            var validationResult = await _validator.ValidateAsync(leaveDto);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            var leaveModel = await _context.Leaves.FindAsync(leaveDto.LeaveID);
            if (leaveModel == null)
            {
                return NotFound();
            }
            leaveModel.EmployeeId = leaveDto.EmployeeId;
            leaveModel.EmployeeName = leaveDto.EmployeeName;
            leaveModel.LeaveType = leaveDto.LeaveType;
            leaveModel.FromDate = leaveDto.FromDate;
            leaveModel.ToDate = leaveDto.ToDate;
            leaveModel.TotalLeaveDuration = leaveDto.TotalLeaveDuration;
            leaveModel.Reason = leaveDto.Reason;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var leaveModel = await _context.Leaves.FindAsync(id);
            if (leaveModel == null)
            {
                return NotFound();
            }
            _context.Leaves.Remove(leaveModel);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    } 
}
