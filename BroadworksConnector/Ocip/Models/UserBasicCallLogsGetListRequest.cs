using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBasicCallLogsGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.BasicCallLogsType _callLogType;

    [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.BasicCallLogsType CallLogType {
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
