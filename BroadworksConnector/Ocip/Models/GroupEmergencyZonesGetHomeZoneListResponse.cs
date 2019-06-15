using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEmergencyZonesGetHomeZoneListRequest.
        /// <see cref="GroupEmergencyZonesGetHomeZoneListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupEmergencyZonesGetHomeZoneListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _homeZoneIpAddress;

        [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false, Namespace = "")]
        public List<string> HomeZoneIpAddress {
            get => _homeZoneIpAddress;
            set {
                HomeZoneIpAddressSpecified = true;
                _homeZoneIpAddress = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneIpAddressSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.IPAddressRange> _homeZoneIpAddressRange;

        [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.IPAddressRange> HomeZoneIpAddressRange {
            get => _homeZoneIpAddressRange;
            set {
                HomeZoneIpAddressRangeSpecified = true;
                _homeZoneIpAddressRange = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneIpAddressRangeSpecified { get; set; }
        
    }
}
