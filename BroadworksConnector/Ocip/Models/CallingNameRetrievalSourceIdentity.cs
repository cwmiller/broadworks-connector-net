using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallingNameRetrievalSourceIdentity
    {
        [XmlEnum(Name = "Presentation Identity")]
        PresentationIdentity,
        [XmlEnum(Name = "Asserted Identity")]
        AssertedIdentity,
    }
}
