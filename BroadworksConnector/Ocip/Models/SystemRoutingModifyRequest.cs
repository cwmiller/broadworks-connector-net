using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "isRouteRoundRobin", IsNullable = false)]
    public bool IsRouteRoundRobin { get; set; }
    [XmlElement(ElementName = "routeTimerSeconds", IsNullable = false)]
    public int RouteTimerSeconds { get; set; }
    [XmlElement(ElementName = "dnsResolvedAddressSelectionPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RoutingDNSResolvedAddressSelectionPolicy DnsResolvedAddressSelectionPolicy { get; set; }
    [XmlElement(ElementName = "statefulExpirationMinutes", IsNullable = false)]
    public int StatefulExpirationMinutes { get; set; }
    [XmlElement(ElementName = "maxAddressesPerHostname", IsNullable = false)]
    public int MaxAddressesPerHostname { get; set; }
    [XmlElement(ElementName = "maxAddressesDuringSetup", IsNullable = false)]
    public int MaxAddressesDuringSetup { get; set; }
 }
}
