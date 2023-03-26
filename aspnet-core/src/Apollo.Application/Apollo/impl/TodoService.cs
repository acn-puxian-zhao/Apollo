using Apollo.Apollo.Todo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;

namespace Apollo.Apollo.impl
{
    [RemoteService(false)]
    public class TodoService : ApolloAppService, ITodoService
    {
        private readonly IRepository<Entities.Todo, long> _todoRepository;

        public TodoService(
            IRepository<Entities.Todo, long> todoRepository
            )
        {
            _todoRepository = todoRepository;
        }

        public async Task<TodoDto> CreateAsync(TodoDto input)
        {
            var entity = ObjectMapper.Map<TodoDto, Entities.Todo>(input);
            var result = await _todoRepository.InsertAsync(entity);

            return ObjectMapper.Map<Entities.Todo, TodoDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _todoRepository.DeleteAsync(id);
        }

        public async Task<List<TodoDto>> GetAllAsync()
        {
            var res = await _todoRepository.GetListAsync();

            var rtn = ObjectMapper.Map<List<Entities.Todo>, List<TodoDto>>(res);

            return rtn;
        }

        public async Task UpdateAsync(TodoDto input)
        {
            var entity = await _todoRepository.GetAsync(x => x.Id == input.Id);

            ObjectMapper.Map(input, entity);

            await _todoRepository.UpdateAsync(entity);
        }

        public async Task<TodoDto> GetAsync(long id)
        {
            var res=  await _todoRepository.GetAsync(id);
            var rtn = ObjectMapper.Map<Entities.Todo, TodoDto>(res);

            return rtn;
        }
    }
}
