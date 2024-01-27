using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify outgoing Calling Plan for Call Me Now call permissions.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1797""}]")]
    public class OutgoingCallingPlanCallMeNowPermissionsModify
    {

        protected bool _group;

        [XmlElement(ElementName = "group", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool Group
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

        protected bool _local;

        [XmlElement(ElementName = "local", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool Local
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

        protected bool _tollFree;

        [XmlElement(ElementName = "tollFree", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool TollFree
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

        protected bool _toll;

        [XmlElement(ElementName = "toll", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool Toll
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

        protected bool _international;

        [XmlElement(ElementName = "international", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool International
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

        protected bool _operatorAssisted;

        [XmlElement(ElementName = "operatorAssisted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool OperatorAssisted
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

        protected bool _chargeableDirectoryAssisted;

        [XmlElement(ElementName = "chargeableDirectoryAssisted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool ChargeableDirectoryAssisted
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

        protected bool _specialServicesI;

        [XmlElement(ElementName = "specialServicesI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool SpecialServicesI
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

        protected bool _specialServicesII;

        [XmlElement(ElementName = "specialServicesII", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool SpecialServicesII
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

        protected bool _premiumServicesI;

        [XmlElement(ElementName = "premiumServicesI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool PremiumServicesI
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

        protected bool _premiumServicesII;

        [XmlElement(ElementName = "premiumServicesII", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool PremiumServicesII
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

        protected bool _casual;

        [XmlElement(ElementName = "casual", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool Casual
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

        protected bool _urlDialing;

        [XmlElement(ElementName = "urlDialing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool UrlDialing
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

        protected bool _unknown;

        [XmlElement(ElementName = "unknown", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1797")]
        public bool Unknown
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
