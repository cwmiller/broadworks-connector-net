using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportCallCenterSelectionRead 
{
    private bool _allCallCenter;

    [XmlElement(ElementName = "allCallCenter", IsNullable = false, Namespace = "")]
    public bool AllCallCenter {
        get => _allCallCenter;
        set {
            AllCallCenterSpecified = true;
            _allCallCenter = value;
        }
    }

    [XmlIgnore]
    public bool AllCallCenterSpecified { get; set; }
    private List<string> _currentUserId;

    [XmlElement(ElementName = "currentUserId", IsNullable = false, Namespace = "")]
    public List<string> CurrentUserId {
        get => _currentUserId;
        set {
            CurrentUserIdSpecified = true;
            _currentUserId = value;
        }
    }

    [XmlIgnore]
    public bool CurrentUserIdSpecified { get; set; }
    private List<string> _pastUserId;

    [XmlElement(ElementName = "pastUserId", IsNullable = false, Namespace = "")]
    public List<string> PastUserId {
        get => _pastUserId;
        set {
            PastUserIdSpecified = true;
            _pastUserId = value;
        }
    }

    [XmlIgnore]
    public bool PastUserIdSpecified { get; set; }
}
}
