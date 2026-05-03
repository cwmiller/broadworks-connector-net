using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Caller Id Disposition verstat value.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallerIdDispositionVerstat
    {
        [XmlEnum(Name = "TN-Validation-Passed")]
        TNValidationPassed,
        [XmlEnum(Name = "TN-Validation-Failed")]
        TNValidationFailed,
        [XmlEnum(Name = "No-TN-Validation")]
        NoTNValidation,
        [XmlEnum(Name = "No-Verstat")]
        NoVerstat,
    }
}
