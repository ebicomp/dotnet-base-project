using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.Features.Leavetype.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Features.Leavetype.Commands.DeleteLeaveType;
using HR.LeaveManagement.Application.Features.Leavetype.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Features.Leavetype.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.Leavetype.Queries.GetLeaveTypeDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.LeaveManagement.API.Controllers
{
    [Route("api/[controller]")]
    public class LeaveTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/values
        [HttpGet]
        public async Task<List<LeaveTypeDto>> GetAll()
        {
            var laeveTypes = await _mediator.Send(new GetLeaveTypesQuery());
            return laeveTypes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<LeaveTypeDetailDto> Get(int id)
        {
            var leaveType = await _mediator.Send(new GetLeaveTypeDetailsQuery() { Id = id });
            return leaveType;
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody] CreateLeaveTypeCommand leaveType)
        {
            var response = await _mediator.Send(leaveType);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateLeaveTypeCommand leaveType)
        {
            await _mediator.Send(leaveType);
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveTypeCommand() { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

