using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O Campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("O Campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () => {
                //RuleFor(f => f.Documento.Length)
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () => {
            
            });
        }
    }
}
