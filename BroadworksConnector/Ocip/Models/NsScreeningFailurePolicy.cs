using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// How the incomming caller ID should be displayed in the case of an NS screening failure
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum NsScreeningFailurePolicy    {
            [XmlEnum(Name = "Display Received Caller ID")]
        DisplayReceivedCallerID,
            [XmlEnum(Name = "Restrict Number")]
        RestrictNumber,
            [XmlEnum(Name = "Restrict Name And Number")]
        RestrictNameAndNumber,
     }
}
