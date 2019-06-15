using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneNetAddressGetListRequest.
        /// <see cref="SystemZoneNetAddressGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneNetAddressGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
    }
}
