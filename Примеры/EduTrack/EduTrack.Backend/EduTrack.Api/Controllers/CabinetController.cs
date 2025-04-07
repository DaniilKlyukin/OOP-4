using EduTrack.Application.Features.Cabinet.Commands;
using EduTrack.Contracts.Cabinet.Create;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EduTrack.Api.Controllers;

[Route("[controller]")]
[AllowAnonymous]
public class CabinetController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public CabinetController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCabinetRequest request)
    {
        var command = _mapper.Map<CreateCabinetCommand>(request);

        var registerResult = await _mediator.Send(command);

        var response = _mapper.Map<CreateCabinetResponse>(registerResult);

        return Ok(response);
    }
}
