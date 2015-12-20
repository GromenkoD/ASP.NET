using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Comment : IBlog
    {
        public int Id { get; set; }
        [UIHint("MultilineText")]
        public string Content { get; set; }

        public int? ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
