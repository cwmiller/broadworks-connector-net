using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainGetListRequest22V2 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "excludeReseller", IsNullable = false)]
    public bool ExcludeReseller { get; set; }
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaDomainName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDomainName> SearchCriteriaDomainName { get; set; }
 }
}
