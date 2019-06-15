using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Redirecting Rule
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallForwardingSelectiveNumberSelection    {
            [XmlEnum(Name = "Forward To Default Number")]
        ForwardToDefaultNumber,
            [XmlEnum(Name = "Forward To Specified Number")]
        ForwardToSpecifiedNumber,
     }
}
