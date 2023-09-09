using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using teacher_crud.Dto;
using teacher_crud.Interface;
using teacher_crud.Models;

namespace teacher_crud.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    public readonly ITeacherService _service;
    public TeacherController(ITeacherService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Teacher>>> ListAsync()
    {
        var teachers = await _service.List();
        return Ok(teachers);
    }

    [HttpPost]
    public async Task<ActionResult<Teacher>> PostAsync([FromForm] TeacherDto teacher)
    {
        var result = await _service.Create(teacher);
        return Created($"teacher={result.Id}", result);
    }

}
