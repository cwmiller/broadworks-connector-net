using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken Verstat Tag.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenVerstatTag
    {
        [XmlEnum(Name = "TN-Validation-Passed")]
        TNValidationPassed,
        [XmlEnum(Name = "TN-Validation-Failed")]
        TNValidationFailed,
        [XmlEnum(Name = "No-TN-Validation")]
        NoTNValidation,
    }
}
