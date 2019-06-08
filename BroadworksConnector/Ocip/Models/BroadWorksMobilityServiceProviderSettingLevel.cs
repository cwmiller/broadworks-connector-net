using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum BroadWorksMobilityServiceProviderSettingLevel{
    [XmlEnum(Name = "ServiceProvider")]
    ServiceProvider,
    [XmlEnum(Name = "System")]
    System,
 }
}
