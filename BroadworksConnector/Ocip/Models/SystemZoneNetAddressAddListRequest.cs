using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneNetAddressAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.IPAddressRange> _netAddressRange;

    [XmlElement(ElementName = "netAddressRange", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.IPAddressRange> NetAddressRange {
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
