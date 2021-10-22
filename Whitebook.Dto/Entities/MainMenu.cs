using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Dto.Dto;

namespace Whitebook.Whitebook.Dto.Entities
{
    public class MainMenu: IEntity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Menu { get; set; }
    }
}
