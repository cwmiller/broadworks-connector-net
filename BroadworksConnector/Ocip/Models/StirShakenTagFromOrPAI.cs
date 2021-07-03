using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken Tag From or PAI headers.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenTagFromOrPAI
    {
        [XmlEnum(Name = "PAI")]
        PAI,
        [XmlEnum(Name = "From")]
        From,
        [XmlEnum(Name = "Both")]
        Both,
    }
}
