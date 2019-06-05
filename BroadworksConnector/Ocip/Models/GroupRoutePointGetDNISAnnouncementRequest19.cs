using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetDNISAnnouncementRequest19 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.DNISKey _dnisKey;

    [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DNISKey DnisKey {
        get => _dnisKey;
        set {
            DnisKeySpecified = true;
            _dnisKey = value;
        }
    }

    [XmlIgnore]
    public bool DnisKeySpecified { get; set; }
}
}
