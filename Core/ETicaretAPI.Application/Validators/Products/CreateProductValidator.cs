using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
       
        public CreateProductValidator() {
        
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz!!")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("Lütfen ürün adını 2 ile 150 karakter arası giriniz.");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen stok alanını boş geçmeyiniz!!")
                .Must(s => s >= 0)
                    .WithMessage("Stok bilgisi 0 veya daha üzeri olmalıdır.");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen fiyat alanını boş geçmeyiniz!!")
                .Must(s => s >= 0)
                    .WithMessage("Fiyat bilgisi 0 veya daha üzeri olmalıdır.");





        }
    }
}
