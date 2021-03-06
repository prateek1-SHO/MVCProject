using System.Collections.Generic;

namespace Web.Mango.Models
{
    public class ResponceDtos
    {
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
        public string DisplayName { get; set; }
        public List<string> ErrorMessage { get; set; }
    }
}
