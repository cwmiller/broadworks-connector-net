using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken verification error handling.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenVerificationErrorHandling
    {
        [XmlEnum(Name = "Abort")]
        Abort,
        [XmlEnum(Name = "Proceed")]
        Proceed,
    }
}
