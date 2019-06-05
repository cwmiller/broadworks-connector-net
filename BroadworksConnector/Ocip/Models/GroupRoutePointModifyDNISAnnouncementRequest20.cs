using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyDNISAnnouncementRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 _mediaOnHoldSource;

    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 MediaOnHoldSource {
        get => _mediaOnHoldSource;
        set {
            MediaOnHoldSourceSpecified = true;
            _mediaOnHoldSource = value;
        }
    }

    [XmlIgnore]
    public bool MediaOnHoldSourceSpecified { get; set; }
}
}
