using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEmergencyZonesGetHomeZoneListRequest.
    /// <see cref="GroupEmergencyZonesGetHomeZoneListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""993492ea5726d0f3ec8743f5cef40e23:103""}]")]
    public class GroupEmergencyZonesGetHomeZoneListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _homeZoneIpAddress = new List<string>();

        [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:103")]
        [MinLength(1)]
        [MaxLength(39)]
        public List<string> HomeZoneIpAddress
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

        protected List<BroadWorksConnector.Ocip.Models.IPAddressRange> _homeZoneIpAddressRange = new List<BroadWorksConnector.Ocip.Models.IPAddressRange>();

        [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:103")]
        public List<BroadWorksConnector.Ocip.Models.IPAddressRange> HomeZoneIpAddressRange
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

    }
}
