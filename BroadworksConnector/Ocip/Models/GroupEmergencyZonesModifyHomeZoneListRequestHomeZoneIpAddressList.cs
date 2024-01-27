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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""993492ea5726d0f3ec8743f5cef40e23:161""}]")]
    public class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList
    {

        protected string _homeZoneIpAddress;

        [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:161")]
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

        protected string _newHomeZoneIpAddress;

        [XmlElement(ElementName = "newHomeZoneIpAddress", IsNullable = false, Namespace = "")]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:161")]
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
