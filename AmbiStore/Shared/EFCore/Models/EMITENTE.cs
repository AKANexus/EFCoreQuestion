using AmbiStore.Shared.Libraries.Enums;
using AmbiStore.Shared.Libraries.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmbiStore.Shared.EFCore.Models
{
    public class EMITENTE : EntityBase
    {
        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(40)]
        public string NOME_FANTASIA { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(40)]
        public string CONTATO_RESPONSAVEL { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(18, ErrorMessage = "Digite o CNPJ sem pontuação")]
        [MinLength(18, ErrorMessage = "Digite o CNPJ sem pontuação")]
        [CPForCPNPJ]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(9, ErrorMessage = "Digite o CEP sem o traço")]
        [MinLength(9, ErrorMessage = "Digite o CEP sem o traço")]
        public string ENDERECO_CEP { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        public TipoLograd ENDERECO_TIPO { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(40)]
        public string ENDERECO_LOGRAD { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(5)]
        public string ENDERECO_NUMERO { get; set; }

        public string ENDERECO_COMPL { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(35)]
        public string ENDERECO_BAIRRO { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(2, ErrorMessage = "Digite o DDD com 2 digitos")]
        [MinLength(2, ErrorMessage = "Digite o DDD com 2 digitos")]
        public string DDD_COMERCIAL { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [RegularExpression("\\d{8,9}", ErrorMessage = "Insira um valor válido.")]
        public string TEL_COMERCIAL { get; set; }

        [MaxLength(2, ErrorMessage = "Digite o DDD com 2 digitos")]
        public string DDD_CELULAR1 { get; set; }

        [RegularExpression("\\d{8,9}", ErrorMessage = "Insira um valor válido.")]
        public string TEL_CELULAR1 { get; set; }

        [MaxLength(2, ErrorMessage = "Digite o DDD com 2 digitos")]
        public string DDD_CELULAR2 { get; set; }

        [RegularExpression("\\d{8,9}", ErrorMessage = "Insira um valor válido.")]
        public string TEL_CELULAR2 { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(16, ErrorMessage = "Digite a IE sem pontuação")]
        public string INSCRICAO_ESTADUAL { get; set; }

        [MaxLength(16)]
        public string INSCRICAO_MUNICIPAL { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [MaxLength(17)]
        public string CNAE { get; set; }

        public bool SIMPLES_NACIONAL { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DT_COMPRA_SISTEMA { get; set; }

        public string RAMO_ATIVIDADE { get; set; }

        public string EMAIL { get; set; }
        public string SITE { get; set; }
        public bool RT_EXCEDE_SUBLIMITE { get; set; }

        //==================
        public int END_MUNICIPIO_ID { get; set; }
        //=============================

        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
    }
}
