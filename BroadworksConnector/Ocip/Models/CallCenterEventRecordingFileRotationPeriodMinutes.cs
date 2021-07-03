using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This parameter specifies the amount of time the active Call Center
    /// activity file is open for recording activities (in minutes). When
    /// the file is closed, a new file is open to continue recording
    /// activities, and the closed file is transferred to a remote host.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterEventRecordingFileRotationPeriodMinutes
    {
        [XmlEnum(Name = "1")]
        _1,
        [XmlEnum(Name = "5")]
        _5,
        [XmlEnum(Name = "10")]
        _10,
        [XmlEnum(Name = "15")]
        _15,
        [XmlEnum(Name = "30")]
        _30,
        [XmlEnum(Name = "60")]
        _60,
    }
}
