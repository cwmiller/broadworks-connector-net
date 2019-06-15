using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible algorithms for digital signatures supported by the provisioning server.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DigitalSignatureAlgorithm    {
            [XmlEnum(Name = "MD5")]
        MD5,
     }
}
