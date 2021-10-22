using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Dto.Dto;

namespace Whitebook.Whitebook.Dto.Entities
{
    public class Content:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

    }
}
