using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutomaticCallbackMethod
    {
        [XmlEnum(Name = "Notify Only")]
        NotifyOnly,
        [XmlEnum(Name = "Notify If Possible And Polling Otherwise")]
        NotifyIfPossibleAndPollingOtherwise,
    }
}
