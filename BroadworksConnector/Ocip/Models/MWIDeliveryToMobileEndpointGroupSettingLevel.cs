using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint setting for the group level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MWIDeliveryToMobileEndpointGroupSettingLevel    {
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
