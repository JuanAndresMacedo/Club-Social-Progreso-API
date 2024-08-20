using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.NewsFolder.Entities
{
    public sealed record class News
    {
        public string Id { get; init; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Date { get; set; } = null!;

        public string Topic { get; set; } = null!;

        public bool VerticalImage { get; set; }

        public News()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
