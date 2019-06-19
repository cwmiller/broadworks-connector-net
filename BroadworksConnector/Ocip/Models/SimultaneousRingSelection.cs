using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Simultaneous Ring Selection.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SimultaneousRingSelection
    {
        [XmlEnum(Name = "Do not Ring if on a Call")]
        DonotRingifonaCall,
        [XmlEnum(Name = "Ring for all Incoming Calls")]
        RingforallIncomingCalls,
    }
}
