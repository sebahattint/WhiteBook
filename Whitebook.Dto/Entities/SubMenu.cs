using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Dto.Dto;

namespace Whitebook.WhiteBookDto.Entities
{
    public  class Submenu:IEntity
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string MenuText { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}
