using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Dto.Dto;
using Whitebook.WhiteBookDto.Entities;

namespace Whitebook.WhiteBookDto.Entities
{
    public class Project: IEntity
    {
        public int Id { get; set; }
        public string Proje { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
