using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Query Protocol.
    /// </summary>
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
