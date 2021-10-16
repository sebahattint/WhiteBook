using System;
using System.Collections.Generic;
using System.Text;

namespace Whitebook.Whitebook.Dto.Entities
{
    public class Content
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

    }
}
