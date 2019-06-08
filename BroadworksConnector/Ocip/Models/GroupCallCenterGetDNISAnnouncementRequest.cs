using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetDNISAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

    [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DNISKey DnisKey {
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
