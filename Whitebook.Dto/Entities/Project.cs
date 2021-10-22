using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Dto.Dto;

namespace Whitebook.Whitebook.Dto.Entities
{
    public class Project: IEntity
    {
        public int Id { get; set; }
        public string Proje { get; set; }
    }
}
