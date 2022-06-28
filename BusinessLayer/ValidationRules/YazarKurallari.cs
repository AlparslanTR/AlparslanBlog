using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class YazarKurallari:AbstractValidator<Yazar>
    {
        public YazarKurallari()
        {
            // Yazar Ad Hata Kurallarıı
            RuleFor(x => x.YazarAd).NotEmpty().WithMessage("Ad Soyad Boş Geçilemez.!");
            RuleFor(x => x.YazarAd).MaximumLength(30).WithMessage("30 Karakterden Fazla Giremezsiniz.!");
            RuleFor(x => x.YazarAd).MinimumLength(3).WithMessage("3 Karakterden Az Giremezsiniz.!");
            // Yazar Mail Hata Kuralları
            RuleFor(x => x.YazarMail).NotEmpty().WithMessage("Mail Kısmı Boş Geçilemez.!");
            RuleFor(x => x.YazarMail).EmailAddress().WithMessage("Geçerli Bir Mail Adresi Girin.!");
            // Yazar Şifre Hata Kuralları
            RuleFor(x => x.YazarSifre).NotEmpty().WithMessage("Şifreyi Boş Geçemezsiniz.!");
            RuleFor(x => x.YazarSifre).MaximumLength(30).MinimumLength(10).WithMessage("Şifreniz En Fazla 30 Karakter İçermelidir. En Az 10 Karakter İçermelidir.!");
        }

    }
}
