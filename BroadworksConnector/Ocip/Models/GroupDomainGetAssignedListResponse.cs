using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDomainGetAssignedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupDefaultDomain", IsNullable = false)]
    public string GroupDefaultDomain { get; set; }
    [XmlElement(ElementName = "domain", IsNullable = false)]
    public List<string> Domain { get; set; }
 }
}
