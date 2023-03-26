using Apollo.Apollo;
using Apollo.Apollo.Todo.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TodoController : ApolloController
    {
        private readonly ITodoService _todoService;

        public TodoController(
            ITodoService todoService
            )
        {
            this._todoService = todoService;
        }

        [HttpPost]
        public async Task<TodoDto> CreateAsync(TodoDto input)
        {
            return await _todoService.CreateAsync(input);
        }

        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _todoService.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<List<TodoDto>> GetAllAsync()
        {
            return await _todoService.GetAllAsync();
        }

        [HttpPut]
        public async Task UpdateAsync(TodoDto input)
        {
            await _todoService.UpdateAsync(input);
        }

        [HttpGet]
        public async Task<TodoDto> GetAsync(long id)
        {
            return await(_todoService.GetAsync(id));
        }
    }
}
