using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities

{
    public class Article : IBlog
    {
        public int Id {get; set;}
        [UIHint("MultilineText")]
        public string ArticleName { get; set; }
        [UIHint("MultilineText")]
        public string ArticleSummary { get; set; }
        [UIHint("MultilineText")]
        public string ArticleContent { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    //    public Article()
    //{
    //    Comments = new List<Comment>();
    //}
    }
}
