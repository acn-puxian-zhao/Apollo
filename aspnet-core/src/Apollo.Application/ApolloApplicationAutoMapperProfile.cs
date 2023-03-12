using Apollo.Apollo.Todo.Dto;
using AutoMapper;

namespace Apollo;

public class ApolloApplicationAutoMapperProfile : Profile
{
    public ApolloApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Entities.Todo, TodoDto>();
        CreateMap<TodoDto, Entities.Todo>();
    }
}
