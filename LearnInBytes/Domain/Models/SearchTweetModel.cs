using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SearchTweetModel
    {
        public string Query { get; set; }
        public string FromId { get; set; }
    }
}
