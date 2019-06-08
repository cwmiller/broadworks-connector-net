using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
