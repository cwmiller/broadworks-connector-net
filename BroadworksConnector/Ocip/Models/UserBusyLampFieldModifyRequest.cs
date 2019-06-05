using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBusyLampFieldModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _listURI;

    [XmlElement(ElementName = "listURI", IsNullable = true, Namespace = "")]
    public string ListURI {
        get => _listURI;
        set {
            ListURISpecified = true;
            _listURI = value;
        }
    }

    [XmlIgnore]
    public bool ListURISpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _monitoredUserIdList;

    [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList MonitoredUserIdList {
        get => _monitoredUserIdList;
        set {
            MonitoredUserIdListSpecified = true;
            _monitoredUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool MonitoredUserIdListSpecified { get; set; }
    private bool _enableCallParkNotification;

    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
    public bool EnableCallParkNotification {
        get => _enableCallParkNotification;
        set {
            EnableCallParkNotificationSpecified = true;
            _enableCallParkNotification = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallParkNotificationSpecified { get; set; }
}
}
