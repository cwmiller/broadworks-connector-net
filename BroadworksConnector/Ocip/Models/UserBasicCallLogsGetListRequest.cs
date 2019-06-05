using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBasicCallLogsGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.BasicCallLogsType _callLogType;

    [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BasicCallLogsType CallLogType {
        get => _callLogType;
        set {
            CallLogTypeSpecified = true;
            _callLogType = value;
        }
    }

    [XmlIgnore]
    public bool CallLogTypeSpecified { get; set; }
}
}
