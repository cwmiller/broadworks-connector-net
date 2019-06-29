using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan originating call permissions.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2039""}]")]
    public class OutgoingCallingPlanOriginatingPermissions
    {

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _group;

        [XmlElement(ElementName = "group", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Group
        {
            get => _group;
            set
            {
                GroupSpecified = true;
                _group = value;
            }
        }

        [XmlIgnore]
        protected bool GroupSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _local;

        [XmlElement(ElementName = "local", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Local
        {
            get => _local;
            set
            {
                LocalSpecified = true;
                _local = value;
            }
        }

        [XmlIgnore]
        protected bool LocalSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _tollFree;

        [XmlElement(ElementName = "tollFree", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission TollFree
        {
            get => _tollFree;
            set
            {
                TollFreeSpecified = true;
                _tollFree = value;
            }
        }

        [XmlIgnore]
        protected bool TollFreeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _toll;

        [XmlElement(ElementName = "toll", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Toll
        {
            get => _toll;
            set
            {
                TollSpecified = true;
                _toll = value;
            }
        }

        [XmlIgnore]
        protected bool TollSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _international;

        [XmlElement(ElementName = "international", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission International
        {
            get => _international;
            set
            {
                InternationalSpecified = true;
                _international = value;
            }
        }

        [XmlIgnore]
        protected bool InternationalSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _operatorAssisted;

        [XmlElement(ElementName = "operatorAssisted", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission OperatorAssisted
        {
            get => _operatorAssisted;
            set
            {
                OperatorAssistedSpecified = true;
                _operatorAssisted = value;
            }
        }

        [XmlIgnore]
        protected bool OperatorAssistedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _chargeableDirectoryAssisted;

        [XmlElement(ElementName = "chargeableDirectoryAssisted", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission ChargeableDirectoryAssisted
        {
            get => _chargeableDirectoryAssisted;
            set
            {
                ChargeableDirectoryAssistedSpecified = true;
                _chargeableDirectoryAssisted = value;
            }
        }

        [XmlIgnore]
        protected bool ChargeableDirectoryAssistedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _specialServicesI;

        [XmlElement(ElementName = "specialServicesI", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission SpecialServicesI
        {
            get => _specialServicesI;
            set
            {
                SpecialServicesISpecified = true;
                _specialServicesI = value;
            }
        }

        [XmlIgnore]
        protected bool SpecialServicesISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _specialServicesII;

        [XmlElement(ElementName = "specialServicesII", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission SpecialServicesII
        {
            get => _specialServicesII;
            set
            {
                SpecialServicesIISpecified = true;
                _specialServicesII = value;
            }
        }

        [XmlIgnore]
        protected bool SpecialServicesIISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _premiumServicesI;

        [XmlElement(ElementName = "premiumServicesI", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission PremiumServicesI
        {
            get => _premiumServicesI;
            set
            {
                PremiumServicesISpecified = true;
                _premiumServicesI = value;
            }
        }

        [XmlIgnore]
        protected bool PremiumServicesISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _premiumServicesII;

        [XmlElement(ElementName = "premiumServicesII", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission PremiumServicesII
        {
            get => _premiumServicesII;
            set
            {
                PremiumServicesIISpecified = true;
                _premiumServicesII = value;
            }
        }

        [XmlIgnore]
        protected bool PremiumServicesIISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _casual;

        [XmlElement(ElementName = "casual", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Casual
        {
            get => _casual;
            set
            {
                CasualSpecified = true;
                _casual = value;
            }
        }

        [XmlIgnore]
        protected bool CasualSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _urlDialing;

        [XmlElement(ElementName = "urlDialing", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission UrlDialing
        {
            get => _urlDialing;
            set
            {
                UrlDialingSpecified = true;
                _urlDialing = value;
            }
        }

        [XmlIgnore]
        protected bool UrlDialingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _unknown;

        [XmlElement(ElementName = "unknown", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2039")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Unknown
        {
            get => _unknown;
            set
            {
                UnknownSpecified = true;
                _unknown = value;
            }
        }

        [XmlIgnore]
        protected bool UnknownSpecified { get; set; }

    }
}
