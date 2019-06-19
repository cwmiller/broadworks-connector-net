using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The presentation indicator for the last redirecting party
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RedirectingPresentationIndicator
    {
        [XmlEnum(Name = "Anonymous")]
        Anonymous,
        [XmlEnum(Name = "Anonymous Name")]
        AnonymousName,
        [XmlEnum(Name = "Anonymous URI")]
        AnonymousURI,
        [XmlEnum(Name = "Public")]
        Public,
    }
}
