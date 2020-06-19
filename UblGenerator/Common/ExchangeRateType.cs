﻿namespace UblGenerator.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ExchangeRateType
    {

        private SourceCurrencyCodeType sourceCurrencyCodeField;

        private TargetCurrencyCodeType targetCurrencyCodeField;

        private CalculationRateType calculationRateField;

        private DateType1 dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceCurrencyCodeType SourceCurrencyCode
        {
            get
            {
                return this.sourceCurrencyCodeField;
            }
            set
            {
                this.sourceCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyCodeType TargetCurrencyCode
        {
            get
            {
                return this.targetCurrencyCodeField;
            }
            set
            {
                this.targetCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationRateType CalculationRate
        {
            get
            {
                return this.calculationRateField;
            }
            set
            {
                this.calculationRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType1 Date
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
    }
}