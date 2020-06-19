﻿namespace UblGenerator.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DespatchType
    {

        private IDType idField;

        private ActualDespatchDateType actualDespatchDateField;

        private ActualDespatchTimeType actualDespatchTimeField;

        private InstructionsType instructionsField;

        private AddressType despatchAddressField;

        private PartyType despatchPartyField;

        private ContactType contactField;

        private PeriodType estimatedDespatchPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDespatchDateType ActualDespatchDate
        {
            get
            {
                return this.actualDespatchDateField;
            }
            set
            {
                this.actualDespatchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDespatchTimeType ActualDespatchTime
        {
            get
            {
                return this.actualDespatchTimeField;
            }
            set
            {
                this.actualDespatchTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionsType Instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        /// <remarks/>
        public AddressType DespatchAddress
        {
            get
            {
                return this.despatchAddressField;
            }
            set
            {
                this.despatchAddressField = value;
            }
        }

        /// <remarks/>
        public PartyType DespatchParty
        {
            get
            {
                return this.despatchPartyField;
            }
            set
            {
                this.despatchPartyField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDespatchPeriod
        {
            get
            {
                return this.estimatedDespatchPeriodField;
            }
            set
            {
                this.estimatedDespatchPeriodField = value;
            }
        }
    }
}