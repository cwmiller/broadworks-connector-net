using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList 
    {

        
        private string _homeZoneIpAddress;

        [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false, Namespace = "")]
        public string HomeZoneIpAddress {
            get => _homeZoneIpAddress;
            set {
                HomeZoneIpAddressSpecified = true;
                _homeZoneIpAddress = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneIpAddressSpecified { get; set; }
        
        private string _newHomeZoneIpAddress;

        [XmlElement(ElementName = "newHomeZoneIpAddress", IsNullable = false, Namespace = "")]
        public string NewHomeZoneIpAddress {
            get => _newHomeZoneIpAddress;
            set {
                NewHomeZoneIpAddressSpecified = true;
                _newHomeZoneIpAddress = value;
            }
        }

        [XmlIgnore]
        public bool NewHomeZoneIpAddressSpecified { get; set; }
        
    }
}
