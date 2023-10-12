using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HompPage.Models
{
    public class ArticleEditViewModel
    {
        public Articles Article { get; set; }

        public List<ArticleFiles> Files { get; set; }

        public List<ArticleComments> Comments { get; set; }

        public byte[] Image { get; set; }
    }
}