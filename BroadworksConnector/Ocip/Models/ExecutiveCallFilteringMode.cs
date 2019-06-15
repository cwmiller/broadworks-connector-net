using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive call filtering mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveCallFilteringMode    {
            [XmlEnum(Name = "Simple")]
        Simple,
            [XmlEnum(Name = "Advanced")]
        Advanced,
     }
}
