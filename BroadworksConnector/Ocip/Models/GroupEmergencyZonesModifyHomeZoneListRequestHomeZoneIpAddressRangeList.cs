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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e71c2205fb31894f87810b330a85ede2:171""}]")]
    public class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList
    {

        private BroadWorksConnector.Ocip.Models.IPAddressRange _homeZoneIpAddressRange;

        [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:171")]
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

        private BroadWorksConnector.Ocip.Models.IPAddressRange _newHomeZoneIpAddressRange;

        [XmlElement(ElementName = "newHomeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:171")]
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
