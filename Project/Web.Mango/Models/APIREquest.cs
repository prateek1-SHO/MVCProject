using static Web.Mango.SD;

namespace Web.Mango.Models
{
    public class APIREquest
    {
        public API_Type aPI_Type { get; set; } = API_Type.GET;
        public string URL { get; set; }
        public object data   { get; set; }
        public string AccessTocken { get; set; }
    }
}
