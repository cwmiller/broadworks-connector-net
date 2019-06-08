using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterMonitoringModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _playToneToAgentForSilentMonitoring;

    [XmlElement(ElementName = "playToneToAgentForSilentMonitoring", IsNullable = false, Namespace = "")]
    public bool PlayToneToAgentForSilentMonitoring {
        get => _playToneToAgentForSilentMonitoring;
        set {
            PlayToneToAgentForSilentMonitoringSpecified = true;
            _playToneToAgentForSilentMonitoring = value;
        }
    }

    [XmlIgnore]
    public bool PlayToneToAgentForSilentMonitoringSpecified { get; set; }
}
}
