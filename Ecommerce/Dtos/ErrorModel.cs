using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos
{
    public class ErrorModel
    {
            public string Title { get; set; }
            public int StatusCode { get; set; }
            public string ErrorMessage { get; set; }
        
    }
}
