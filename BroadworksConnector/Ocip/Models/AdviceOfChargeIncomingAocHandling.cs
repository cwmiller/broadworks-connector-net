using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for method of how the Advice of Charge is processed by the Application Server.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AdviceOfChargeIncomingAocHandling    {
            [XmlEnum(Name = "Ignore")]
        Ignore,
            [XmlEnum(Name = "Charge")]
        Charge,
     }
}
