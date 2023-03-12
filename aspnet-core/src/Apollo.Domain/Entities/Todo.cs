using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Apollo.Entities
{
    public class Todo: AggregateRoot<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
