using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies at which level in the system an call center call disposition code is created.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallDispositionCodeLevel    {
            [XmlEnum(Name = "Enterprise")]
        Enterprise,
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "Queue")]
        Queue,
     }
}
