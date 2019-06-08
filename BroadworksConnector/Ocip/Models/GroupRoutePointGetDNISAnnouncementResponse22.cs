using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetDNISAnnouncementResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead22 _mediaOnHoldSource;

    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead22 MediaOnHoldSource {
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
