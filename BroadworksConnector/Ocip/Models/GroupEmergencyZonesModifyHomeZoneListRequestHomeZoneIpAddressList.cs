using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e71c2205fb31894f87810b330a85ede2:162""}]")]
    public class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList
    {

        private string _homeZoneIpAddress;

        [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:162")]
        [MinLength(1)]
        [MaxLength(39)]
        public string HomeZoneIpAddress
        {
            get => _homeZoneIpAddress;
            set
            {
                HomeZoneIpAddressSpecified = true;
                _homeZoneIpAddress = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIpAddressSpecified { get; set; }

        private string _newHomeZoneIpAddress;

        [XmlElement(ElementName = "newHomeZoneIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:162")]
        [MinLength(1)]
        [MaxLength(39)]
        public string NewHomeZoneIpAddress
        {
            get => _newHomeZoneIpAddress;
            set
            {
                NewHomeZoneIpAddressSpecified = true;
                _newHomeZoneIpAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NewHomeZoneIpAddressSpecified { get; set; }

    }
}
