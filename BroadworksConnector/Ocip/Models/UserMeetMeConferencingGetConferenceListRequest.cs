using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _bridgeId;

    [XmlElement(ElementName = "bridgeId", IsNullable = false, Namespace = "")]
    public string BridgeId {
        get => _bridgeId;
        set {
            BridgeIdSpecified = true;
            _bridgeId = value;
        }
    }

    [XmlIgnore]
    public bool BridgeIdSpecified { get; set; }
}
}
