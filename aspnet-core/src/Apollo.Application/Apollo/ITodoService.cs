using Apollo.Apollo.Todo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Apollo
{
    public interface ITodoService
    {
        Task <TodoDto> CreateAsync(TodoDto input);
        Task DeleteAsync(int id);
        Task<List<TodoDto>> GetAllAsync();

        Task<TodoDto> GetAsync(long id);
        Task UpdateAsync(TodoDto input);
    }
}
