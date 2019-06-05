using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesAddHomeZoneListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.IPAddressRange> _homeZoneIpAddressRange;

    [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.IPAddressRange> HomeZoneIpAddressRange {
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
