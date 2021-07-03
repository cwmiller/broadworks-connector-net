using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group endpoint that can have multiple contacts.
    /// alternateTrunkIdentityDomain is only used in XS mode and the AS when deployed in IMS mode.
    /// Both alternateTrunkIdentity and AlternateTrunkIdentityDomain should be set at the same time if one is set in XS mode.
    /// The following elements are only used in AS data mode and are ignored in XS data mode:
    /// physicalLocation
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4849""}]")]
    public class TrunkAddressingMultipleContactAdd22
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointAdd22 _trunkGroupDeviceEndpoint;

        [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4849")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointAdd22 TrunkGroupDeviceEndpoint
        {
            get => _trunkGroupDeviceEndpoint;
            set
            {
                TrunkGroupDeviceEndpointSpecified = true;
                _trunkGroupDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupDeviceEndpointSpecified { get; set; }

        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4849")]
        [MinLength(1)]
        [MaxLength(30)]
        public string EnterpriseTrunkName
        {
            get => _enterpriseTrunkName;
            set
            {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseTrunkNameSpecified { get; set; }

        private string _alternateTrunkIdentity;

        [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4849")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlternateTrunkIdentity
        {
            get => _alternateTrunkIdentity;
            set
            {
                AlternateTrunkIdentitySpecified = true;
                _alternateTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateTrunkIdentitySpecified { get; set; }

        private string _alternateTrunkIdentityDomain;

        [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4849")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlternateTrunkIdentityDomain
        {
            get => _alternateTrunkIdentityDomain;
            set
            {
                AlternateTrunkIdentityDomainSpecified = true;
                _alternateTrunkIdentityDomain = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateTrunkIdentityDomainSpecified { get; set; }

        private string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4849")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PhysicalLocation
        {
            get => _physicalLocation;
            set
            {
                PhysicalLocationSpecified = true;
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool PhysicalLocationSpecified { get; set; }

    }
}
