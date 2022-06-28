using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogKurallari : AbstractValidator<Blog>
    {
        public BlogKurallari()
        {
            //Blog Başlığı Hata kuralları
            RuleFor(x=>x.BlogBasligi).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.!");
            RuleFor(x => x.BlogBasligi).MinimumLength(8).WithMessage("En Az 8 Karakter Girin.!");
            RuleFor(x => x.BlogBasligi).MaximumLength(45).WithMessage("En Fazla 45 Karakter Girebilirsiniz.!");
            //Blog İçeri Hata Kuralları
            RuleFor(x => x.BlogIcerik).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.!");
            RuleFor(x => x.BlogIcerik).MinimumLength(10).WithMessage("En Az 10 Karakter Girin.!");
            RuleFor(x => x.BlogIcerik).MaximumLength(3000).WithMessage("En Fazla 3000 Karakter Girebilirsiniz.!");
            //Blog Ufak Resim Hata Kuralları
            RuleFor(x => x.BlogUfakResim).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.!");
            //Blog Resim Hata Kuralları
            RuleFor(x => x.BlogResim).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.!");
            //Blog Kategori Hata Kuralları
            //RuleFor(x => x.kategori).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.!");
        }
    }
}
