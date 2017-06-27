using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sample.Repositary.Model
{
    public class Post : ModelBase
    {
        public virtual Person Author { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        [DisplayName("URL for external content")]
        public string ExternalContent { get; set; }
    }
}