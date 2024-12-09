using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class DocumentValidator : AbstractValidator<string>
    {
        public DocumentValidator()
        {
            RuleFor(doc => doc)
                .NotEmpty().WithMessage("Document cannot be empty.")
                .Must(IsValidDocument).WithMessage("Invalid CPF or CNPJ.");
        }

        private bool IsValidDocument(string document)
        {
            if (string.IsNullOrWhiteSpace(document)) return false;

            string cleanedDocument = Regex.Replace(document, @"[^\d]", "");
            return IsCpf(cleanedDocument) || IsCnpj(cleanedDocument);
        }

        private bool IsCpf(string cpf)
        {
            if (cpf.Length != 11) return false;

            // Validação de CPF
            var firstDigit = CalculateCpfDigit(cpf.Substring(0, 9));
            var secondDigit = CalculateCpfDigit(cpf.Substring(0, 9) + firstDigit);

            return cpf.EndsWith(firstDigit.ToString() + secondDigit.ToString());
        }

        private bool IsCnpj(string cnpj)
        {
            if (cnpj.Length != 14) return false;

            // Validação de CNPJ
            var firstDigit = CalculateCnpjDigit(cnpj.Substring(0, 12));
            var secondDigit = CalculateCnpjDigit(cnpj.Substring(0, 12) + firstDigit);

            return cnpj.EndsWith(firstDigit.ToString() + secondDigit.ToString());
        }

        private int CalculateCpfDigit(string cpf)
        {
            int[] multipliers = cpf.Length == 9 ? new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 } : new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 0; i < cpf.Length; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * multipliers[i];
            }

            int remainder = sum % 11;
            return remainder < 2 ? 0 : 11 - remainder;
        }

        private int CalculateCnpjDigit(string cnpj)
        {
            int[] multipliers = cnpj.Length == 12 ? new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 } : new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 0; i < cnpj.Length; i++)
            {
                sum += int.Parse(cnpj[i].ToString()) * multipliers[i];
            }

            int remainder = sum % 11;
            return remainder < 2 ? 0 : 11 - remainder;
        }
    }
}
