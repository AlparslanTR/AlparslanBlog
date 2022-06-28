using Microsoft.AspNetCore.Http;

namespace AlparslanBlog.Models
{
    public class ProfilResmi
    {
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarMail { get; set; }
        public string YazarSifre { get; set; }
        public string YazarHakkinda { get; set; }
        public IFormFile YazarResim { get; set; }
        public bool YazarDurumu { get; set; }
    }
}
