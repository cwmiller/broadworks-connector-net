using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint template types.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MWIDeliveryToMobileEndpointTemplateType
    {
        [XmlEnum(Name = "Default")]
        Default,
        [XmlEnum(Name = "Single New No Previous Message")]
        SingleNewNoPreviousMessage,
        [XmlEnum(Name = "Single New With Previous Message")]
        SingleNewWithPreviousMessage,
        [XmlEnum(Name = "Multiple New Messages")]
        MultipleNewMessages,
    }
}
