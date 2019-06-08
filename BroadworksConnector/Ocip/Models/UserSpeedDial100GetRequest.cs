using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSpeedDial100GetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private int _speedCode;

    [XmlElement(ElementName = "speedCode", IsNullable = false, Namespace = "")]
    public int SpeedCode {
        get => _speedCode;
        set {
            SpeedCodeSpecified = true;
            _speedCode = value;
        }
    }

    [XmlIgnore]
    public bool SpeedCodeSpecified { get; set; }
}
}
