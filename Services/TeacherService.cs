using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using teacher_crud.Dto;
using teacher_crud.Interface;
using teacher_crud.Migrations;
using teacher_crud.Models;

namespace teacher_crud.Services;

public class TeacherService : ITeacherService
{
    public readonly ApplicationDbContext _context;
    public TeacherService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Teacher> Create(TeacherDto dto)
    {
        var teacher = new Teacher
        {
            Name = dto.Name
        };

        await _context.Teachers.AddAsync(teacher);
        await _context.SaveChangesAsync();
        return teacher;
    }

    public async Task<List<Teacher>> List()
    {
        var teachers = await _context.Teachers.ToListAsync();

        return teachers;
    }
}
