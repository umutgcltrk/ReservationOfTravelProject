using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen resim seçiniz !");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsin !");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("En az 50 karakter");
           
            

        }
    }
}
