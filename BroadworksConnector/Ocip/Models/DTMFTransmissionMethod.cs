using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The DTMF transmission method.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DTMFTransmissionMethod
    {
        [XmlEnum(Name = "Signaling")]
        Signaling,
        [XmlEnum(Name = "RTP")]
        RTP,
    }
}
