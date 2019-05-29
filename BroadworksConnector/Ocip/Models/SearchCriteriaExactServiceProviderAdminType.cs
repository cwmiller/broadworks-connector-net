using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactServiceProviderAdminType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminType Type { get; set; }
 }
}
