using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The GETS Call Identifier Mode.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GETSCallIdentifierMode
    {
        [XmlEnum(Name = "Request-URI")]
        RequestURI,
        [XmlEnum(Name = "RPH")]
        RPH,
        [XmlEnum(Name = "RPH-Request-URI")]
        RPHRequestURI,
    }
}
