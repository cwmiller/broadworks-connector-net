using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false)]
    public string SystemDefaultDomain { get; set; }
    [XmlElement(ElementName = "domain", IsNullable = false)]
    public List<string> Domain { get; set; }
 }
}
