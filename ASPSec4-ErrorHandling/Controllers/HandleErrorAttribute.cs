namespace ASPSec4_ErrorHandling.Controllers
{
    internal class HandleErrorAttribute : Attribute
    {
        public string View { get; set; }
    }
}