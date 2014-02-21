using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Renegades.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string Headder { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public int TeamId { get; set; }
        public string Photo { get; set; }
        public int DefPhoto { get; set; }
    }
}