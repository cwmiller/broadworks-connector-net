using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderOfficeZoneAssignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "officeZoneName", IsNullable = false)]
    public List<string> OfficeZoneName { get; set; }
    [XmlElement(ElementName = "defaultOfficeZoneName", IsNullable = false)]
    public string DefaultOfficeZoneName { get; set; }
 }
}
