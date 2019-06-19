using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible type of answer confirmation for Call Me Now.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallMeNowAnswerConfirmation
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Any Key")]
        AnyKey,
        [XmlEnum(Name = "Passcode")]
        Passcode,
    }
}
