using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sample.Repositary.Model
{
    public class Message : ModelBase
    {
        public virtual Person PersonFrom { get; set; }
        public virtual Person PersonTo { get; set; }
        public string Text { get; set; }
    }
}