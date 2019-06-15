using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// System Call Type
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemCallType    {
            [XmlEnum(Name = "Emergency")]
        Emergency,
            [XmlEnum(Name = "Repair")]
        Repair,
     }
}
