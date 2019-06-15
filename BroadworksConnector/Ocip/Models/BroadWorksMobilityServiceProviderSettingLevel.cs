using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// BroadWorks Mobility setting for the service provider level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksMobilityServiceProviderSettingLevel    {
            [XmlEnum(Name = "ServiceProvider")]
        ServiceProvider,
            [XmlEnum(Name = "System")]
        System,
     }
}
