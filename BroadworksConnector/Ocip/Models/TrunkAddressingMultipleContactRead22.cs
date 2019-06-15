using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group endpoint that can have multiple contacts.
    /// alternateTrunkIdentityDomain is only used in XS mode and the AS when deployed in IMS mode.
    /// The following elements are only used in AS data mode and are ignored in XS data mode:
    /// physicalLocation
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class TrunkAddressingMultipleContactRead22 
    {

        
        private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead22 _trunkGroupDeviceEndpoint;

        [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead22 TrunkGroupDeviceEndpoint {
            get => _trunkGroupDeviceEndpoint;
            set {
                TrunkGroupDeviceEndpointSpecified = true;
                _trunkGroupDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupDeviceEndpointSpecified { get; set; }
        
        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
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

        [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false, Namespace = "")]
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

        [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = false, Namespace = "")]
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

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
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
