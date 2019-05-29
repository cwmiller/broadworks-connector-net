using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false)]
    public string SystemDefaultDomain { get; set; }
    [XmlElement(ElementName = "domainTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DomainTable { get; set; }
 }
}
