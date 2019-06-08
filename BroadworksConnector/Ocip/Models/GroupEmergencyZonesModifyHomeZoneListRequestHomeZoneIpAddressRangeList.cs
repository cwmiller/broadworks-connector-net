using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList 
{
    private BroadWorksConnector.Ocip.Models.IPAddressRange _homeZoneIpAddressRange;

    [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.IPAddressRange HomeZoneIpAddressRange {
        get => _homeZoneIpAddressRange;
        set {
            HomeZoneIpAddressRangeSpecified = true;
            _homeZoneIpAddressRange = value;
        }
    }

    [XmlIgnore]
    public bool HomeZoneIpAddressRangeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.IPAddressRange _newHomeZoneIpAddressRange;

    [XmlElement(ElementName = "newHomeZoneIpAddressRange", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.IPAddressRange NewHomeZoneIpAddressRange {
        get => _newHomeZoneIpAddressRange;
        set {
            NewHomeZoneIpAddressRangeSpecified = true;
            _newHomeZoneIpAddressRange = value;
        }
    }

    [XmlIgnore]
    public bool NewHomeZoneIpAddressRangeSpecified { get; set; }
}
}
