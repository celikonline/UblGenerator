﻿namespace UblGenerator.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentMeansType
    {

        private PaymentMeansCodeType paymentMeansCodeField;

        private PaymentDueDateType paymentDueDateField;

        private PaymentChannelCodeType paymentChannelCodeField;

        private InstructionNoteType instructionNoteField;

        private FinancialAccountType payerFinancialAccountField;

        private FinancialAccountType payeeFinancialAccountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentMeansCodeType PaymentMeansCode
        {
            get
            {
                return this.paymentMeansCodeField;
            }
            set
            {
                this.paymentMeansCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDueDateType PaymentDueDate
        {
            get
            {
                return this.paymentDueDateField;
            }
            set
            {
                this.paymentDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentChannelCodeType PaymentChannelCode
        {
            get
            {
                return this.paymentChannelCodeField;
            }
            set
            {
                this.paymentChannelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionNoteType InstructionNote
        {
            get
            {
                return this.instructionNoteField;
            }
            set
            {
                this.instructionNoteField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType PayerFinancialAccount
        {
            get
            {
                return this.payerFinancialAccountField;
            }
            set
            {
                this.payerFinancialAccountField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType PayeeFinancialAccount
        {
            get
            {
                return this.payeeFinancialAccountField;
            }
            set
            {
                this.payeeFinancialAccountField = value;
            }
        }
    }
}