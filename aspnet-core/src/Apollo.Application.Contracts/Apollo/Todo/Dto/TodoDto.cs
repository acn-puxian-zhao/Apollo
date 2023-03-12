using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Apollo.Apollo.Todo.Dto
{
    public class TodoDto: EntityDto<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; } = DateTime.Now;
    }
}
