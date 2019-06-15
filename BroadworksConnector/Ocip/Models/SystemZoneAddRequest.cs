using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Zone and optional Net Addresses and Physical Locations.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        public string ZoneName {
            get => _zoneName;
            set {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        public bool ZoneNameSpecified { get; set; }
        
        private List<string> _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public List<string> NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.IPAddressRange> _netAddressRange;

        [XmlElement(ElementName = "netAddressRange", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.IPAddressRange> NetAddressRange {
            get => _netAddressRange;
            set {
                NetAddressRangeSpecified = true;
                _netAddressRange = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressRangeSpecified { get; set; }
        
        private List<string> _locationBasedPhysicalLocation;

        [XmlElement(ElementName = "locationBasedPhysicalLocation", IsNullable = false, Namespace = "")]
        public List<string> LocationBasedPhysicalLocation {
            get => _locationBasedPhysicalLocation;
            set {
                LocationBasedPhysicalLocationSpecified = true;
                _locationBasedPhysicalLocation = value;
            }
        }

        [XmlIgnore]
        public bool LocationBasedPhysicalLocationSpecified { get; set; }
        
        private string _callingZonePhysicalLocation;

        [XmlElement(ElementName = "callingZonePhysicalLocation", IsNullable = false, Namespace = "")]
        public string CallingZonePhysicalLocation {
            get => _callingZonePhysicalLocation;
            set {
                CallingZonePhysicalLocationSpecified = true;
                _callingZonePhysicalLocation = value;
            }
        }

        [XmlIgnore]
        public bool CallingZonePhysicalLocationSpecified { get; set; }
        
    }
}
