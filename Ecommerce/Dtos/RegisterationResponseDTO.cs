using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos
{
    public class RegisterationResponseDTO
    {
        public bool IsRegisterationSuccessful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
