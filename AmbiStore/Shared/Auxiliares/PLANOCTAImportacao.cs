using AmbiStore.Shared.EFCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AmbiStore.Shared.Auxiliares
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SELECT_FROM_TB_PLANO_CONTAS
    {

        private SELECT_FROM_TB_PLANO_CONTASDATA_RECORD[] dATA_RECORDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DATA_RECORD")]
        public SELECT_FROM_TB_PLANO_CONTASDATA_RECORD[] DATA_RECORD
        {
            get
            {
                return this.dATA_RECORDField;
            }
            set
            {
                this.dATA_RECORDField = value;
            }
        }

        internal List<PLANO_CONTA> listaPlanoContas()
        {

            List<PLANO_CONTA> lista = new List<PLANO_CONTA>();
            foreach (SELECT_FROM_TB_PLANO_CONTASDATA_RECORD dr in DATA_RECORD)
            {
                lista.Add(new PLANO_CONTA() { ID = dr.ID_CTAPLA, DESCRICAO = dr.DESCRICAO, COD_CONTA = dr.COD_CONTA, COD_PAI = dr.COD_PAI });
            }
            return lista;


        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class SELECT_FROM_TB_PLANO_CONTASDATA_RECORD
        {

            private byte iD_CTAPLAField;

            private string dESCRICAOField;

            private string cOD_SPEDField;

            private string cOD_CONTAField;

            private string cOD_PAIField;

            /// <remarks/>
            public byte ID_CTAPLA
            {
                get
                {
                    return this.iD_CTAPLAField;
                }
                set
                {
                    this.iD_CTAPLAField = value;
                }
            }

            /// <remarks/>
            public string DESCRICAO
            {
                get
                {
                    return this.dESCRICAOField;
                }
                set
                {
                    this.dESCRICAOField = value;
                }
            }

            /// <remarks/>
            public string COD_SPED
            {
                get
                {
                    return this.cOD_SPEDField;
                }
                set
                {
                    this.cOD_SPEDField = value;
                }
            }

            /// <remarks/>
            public string COD_CONTA
            {
                get
                {
                    return this.cOD_CONTAField;
                }
                set
                {
                    this.cOD_CONTAField = value;
                }
            }

            /// <remarks/>
            public string COD_PAI
            {
                get
                {
                    return this.cOD_PAIField;
                }
                set
                {
                    this.cOD_PAIField = value;
                }
            }
        }


    }
    //public class PLANOCTAImportacao
    //{

    //    public List<SELECT_FROM_TB_PLANO_CONTASDATA_RECORD> TB_PLANO_CTA { get; set; }

    //    public PLANOCTAImportacao()
    //    {
    //        //c = new List<SELECT_FROM_TB_PLANO_CONTASDATA_RECORD>();
    //    }

    //    public List<PLANO_CONTA> listaPlanoContas()
    //    {
    //        List<PLANO_CONTA> lista = new List<PLANO_CONTA>();
    //        foreach (SELECT_FROM_TB_PLANO_CONTASDATA_RECORD dr in TB_PLANO_CTA)
    //        {
    //            lista.Add(new PLANO_CONTA() { ID = dr.ID_CTAPLA, DESCRICAO = dr.DESCRICAO, COD_CONTA = dr.COD_CONTA, COD_PAI = dr.COD_PAI });
    //        }
    //        return lista;
    //    }

    //}
}
