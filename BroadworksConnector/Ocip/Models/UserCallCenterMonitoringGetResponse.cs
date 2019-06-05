using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterMonitoringGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
