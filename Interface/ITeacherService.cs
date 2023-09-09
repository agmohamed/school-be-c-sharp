using teacher_crud.Dto;
using teacher_crud.Models;

namespace teacher_crud.Interface;

public interface ITeacherService
{
    Task<Teacher> Create(TeacherDto dto);
    Task<List<Teacher>> List();
}