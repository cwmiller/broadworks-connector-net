using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Query Protocol.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallingNameRetrievalQueryProtocol    {
            [XmlEnum(Name = "Sip")]
        Sip,
            [XmlEnum(Name = "Soap")]
        Soap,
     }
}
