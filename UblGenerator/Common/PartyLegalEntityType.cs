﻿namespace UblGenerator.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PartyLegalEntityType
    {

        private RegistrationNameType registrationNameField;

        private CompanyIDType companyIDField;

        private RegistrationDateType registrationDateField;

        private SoleProprietorshipIndicatorType soleProprietorshipIndicatorField;

        private CorporateStockAmountType corporateStockAmountField;

        private FullyPaidSharesIndicatorType fullyPaidSharesIndicatorField;

        private CorporateRegistrationSchemeType corporateRegistrationSchemeField;

        private PartyType headOfficePartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNameType RegistrationName
        {
            get
            {
                return this.registrationNameField;
            }
            set
            {
                this.registrationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyIDType CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationDateType RegistrationDate
        {
            get
            {
                return this.registrationDateField;
            }
            set
            {
                this.registrationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
        {
            get
            {
                return this.soleProprietorshipIndicatorField;
            }
            set
            {
                this.soleProprietorshipIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorporateStockAmountType CorporateStockAmount
        {
            get
            {
                return this.corporateStockAmountField;
            }
            set
            {
                this.corporateStockAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
        {
            get
            {
                return this.fullyPaidSharesIndicatorField;
            }
            set
            {
                this.fullyPaidSharesIndicatorField = value;
            }
        }

        /// <remarks/>
        public CorporateRegistrationSchemeType CorporateRegistrationScheme
        {
            get
            {
                return this.corporateRegistrationSchemeField;
            }
            set
            {
                this.corporateRegistrationSchemeField = value;
            }
        }

        /// <remarks/>
        public PartyType HeadOfficeParty
        {
            get
            {
                return this.headOfficePartyField;
            }
            set
            {
                this.headOfficePartyField = value;
            }
        }
    }
}