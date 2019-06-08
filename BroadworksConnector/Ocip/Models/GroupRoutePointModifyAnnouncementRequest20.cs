using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyAnnouncementRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 _mediaOnHoldSource;

    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 MediaOnHoldSource {
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
