using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The IMS direction for VTR.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum IMSCallType
    {
        [XmlEnum(Name = "Originating")]
        Originating,
        [XmlEnum(Name = "Terminating")]
        Terminating,
    }
}
