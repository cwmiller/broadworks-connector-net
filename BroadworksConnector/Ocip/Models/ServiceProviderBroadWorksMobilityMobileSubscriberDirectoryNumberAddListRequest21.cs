using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "mobileNetworkName", IsNullable = false)]
    public string MobileNetworkName { get; set; }
    [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false)]
    public List<string> MobileSubscriberDirectoryNumber { get; set; }
 }
}
