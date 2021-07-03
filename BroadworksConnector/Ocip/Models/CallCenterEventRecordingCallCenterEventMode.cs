using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This parameter controls whether to enable the Call Center Event
    /// Recording service, the Enhanced Call Center Reporting service, or
    /// both services.
    /// “Call Center Event Recording” indicates the Call Center Event
    /// Recording service is enabled, and the ECCR service is disabled.
    /// “Legacy ECCR” indicates the Call Center Event Recording service
    /// is disabled, and the ECCR service is enabled.
    /// “Both” indicates both the Call Center Event Recording service and
    /// the ECCR service are enabled.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterEventRecordingCallCenterEventMode
    {
        [XmlEnum(Name = "Call Center Event Recording")]
        CallCenterEventRecording,
        [XmlEnum(Name = "Legacy ECCR")]
        LegacyECCR,
        [XmlEnum(Name = "Both")]
        Both,
    }
}
