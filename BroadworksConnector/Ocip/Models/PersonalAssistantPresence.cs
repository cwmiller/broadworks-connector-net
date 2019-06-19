using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Personal Assistant Presence.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PersonalAssistantPresence
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Business Trip")]
        BusinessTrip,
        [XmlEnum(Name = "Gone for the Day")]
        GonefortheDay,
        [XmlEnum(Name = "Lunch")]
        Lunch,
        [XmlEnum(Name = "Meeting")]
        Meeting,
        [XmlEnum(Name = "Out Of Office")]
        OutOfOffice,
        [XmlEnum(Name = "Temporarily Out")]
        TemporarilyOut,
        [XmlEnum(Name = "Training")]
        Training,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
        [XmlEnum(Name = "Vacation")]
        Vacation,
    }
}
