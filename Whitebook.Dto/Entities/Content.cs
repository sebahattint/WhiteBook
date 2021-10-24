using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Dto.Dto;

namespace Whitebook.WhiteBookDto.Entities
{
    public class Content:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }

    }
}
