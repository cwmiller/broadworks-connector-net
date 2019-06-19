using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Session Admission Control handling for Music On Hold types.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SessionAdmissionControlForMusicOnHoldType
    {
        [XmlEnum(Name = "Do Not Play")]
        DoNotPlay,
        [XmlEnum(Name = "Play And Count")]
        PlayAndCount,
    }
}
