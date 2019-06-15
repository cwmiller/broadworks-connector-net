using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group endpoint that can have multiple contacts.
    /// alternateTrunkIdentityDomain is only used in XS mode and the AS when deployed in IMS mode.
    /// Setting alternateTrunkIdentity or alternateTrunkIdentityDomain to nil in XS mode, the other one paremter should be set to nil at the same time.
    /// The following elements are only used in AS data mode and are ignored in XS data mode:
    /// physicalLocation
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class TrunkAddressingMultipleContactModify 
    {

        
        private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointModify _trunkGroupDeviceEndpoint;

        [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointModify TrunkGroupDeviceEndpoint {
            get => _trunkGroupDeviceEndpoint;
            set {
                TrunkGroupDeviceEndpointSpecified = true;
                _trunkGroupDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupDeviceEndpointSpecified { get; set; }
        
        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = true, Namespace = "")]
        public string EnterpriseTrunkName {
            get => _enterpriseTrunkName;
            set {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkNameSpecified { get; set; }
        
        private string _alternateTrunkIdentity;

        [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = true, Namespace = "")]
        public string AlternateTrunkIdentity {
            get => _alternateTrunkIdentity;
            set {
                AlternateTrunkIdentitySpecified = true;
                _alternateTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool AlternateTrunkIdentitySpecified { get; set; }
        
        private string _alternateTrunkIdentityDomain;

        [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = true, Namespace = "")]
        public string AlternateTrunkIdentityDomain {
            get => _alternateTrunkIdentityDomain;
            set {
                AlternateTrunkIdentityDomainSpecified = true;
                _alternateTrunkIdentityDomain = value;
            }
        }

        [XmlIgnore]
        public bool AlternateTrunkIdentityDomainSpecified { get; set; }
        
        private string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = true, Namespace = "")]
        public string PhysicalLocation {
            get => _physicalLocation;
            set {
                PhysicalLocationSpecified = true;
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        public bool PhysicalLocationSpecified { get; set; }
        
    }
}
