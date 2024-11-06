using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingBargain.Data
{
    public class Review
    {
    public int Id { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
    public int ProductId { get; set; }
    public string UserId { get; set; }
    }
}