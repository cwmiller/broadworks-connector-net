using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive rollover action.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveRolloverActionType
    {
        [XmlEnum(Name = "Voice Messaging")]
        VoiceMessaging,
        [XmlEnum(Name = "Forward")]
        Forward,
        [XmlEnum(Name = "No Answer Processing")]
        NoAnswerProcessing,
    }
}
