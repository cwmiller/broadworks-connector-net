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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""993492ea5726d0f3ec8743f5cef40e23:170""}]")]
    public class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList
    {

        protected BroadWorksConnector.Ocip.Models.IPAddressRange _homeZoneIpAddressRange;

        [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:170")]
        public BroadWorksConnector.Ocip.Models.IPAddressRange HomeZoneIpAddressRange
        {
            get => _homeZoneIpAddressRange;
            set
            {
                HomeZoneIpAddressRangeSpecified = true;
                _homeZoneIpAddressRange = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIpAddressRangeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.IPAddressRange _newHomeZoneIpAddressRange;

        [XmlElement(ElementName = "newHomeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:170")]
        public BroadWorksConnector.Ocip.Models.IPAddressRange NewHomeZoneIpAddressRange
        {
            get => _newHomeZoneIpAddressRange;
            set
            {
                NewHomeZoneIpAddressRangeSpecified = true;
                _newHomeZoneIpAddressRange = value;
            }
        }

        [XmlIgnore]
        protected bool NewHomeZoneIpAddressRangeSpecified { get; set; }

    }
}
