using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Push to talk outgoing connection type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PushToTalkOutgoingConnectionSelection
    {
        [XmlEnum(Name = "One Way")]
        OneWay,
        [XmlEnum(Name = "Two Way")]
        TwoWay,
    }
}
