using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint template tag.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MWIDeliveryToMobileEndpointTemplateTag23
    {
        [XmlEnum(Name = "Voice Mail Number")]
        VoiceMailNumber,
        [XmlEnum(Name = "New Messages Count")]
        NewMessagesCount,
        [XmlEnum(Name = "Total Messages Count")]
        TotalMessagesCount,
        [XmlEnum(Name = "Caller Name")]
        CallerName,
        [XmlEnum(Name = "Caller Number")]
        CallerNumber,
        [XmlEnum(Name = "Hour")]
        Hour,
        [XmlEnum(Name = "Minute")]
        Minute,
        [XmlEnum(Name = "Day Of Month")]
        DayOfMonth,
        [XmlEnum(Name = "Month")]
        Month,
        [XmlEnum(Name = "Year")]
        Year,
        [XmlEnum(Name = "New Messages From Caller")]
        NewMessagesFromCaller,
        [XmlEnum(Name = "Total Messages From Caller")]
        TotalMessagesFromCaller,
    }
}
