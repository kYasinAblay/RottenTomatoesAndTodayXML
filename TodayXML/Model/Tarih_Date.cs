using System;
using System.Collections.Generic;
using System.Text;

namespace TodayXML.Model
{

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public class Tarih_Date
        {

            private Tarih_DateCurrency[] currencyField;

            private string tarihField;

            private string dateField;

            private string bulten_NoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Currency")]
            public Tarih_DateCurrency[] Currency
            {
                get
                {
                    return this.currencyField;
                }
                set
                {
                    this.currencyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Tarih
            {
                get
                {
                    return this.tarihField;
                }
                set
                {
                    this.tarihField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Bulten_No
            {
                get
                {
                    return this.bulten_NoField;
                }
                set
                {
                    this.bulten_NoField = value;
                }
            }
        }
    }

