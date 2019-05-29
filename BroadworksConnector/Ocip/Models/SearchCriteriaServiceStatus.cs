using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaServiceStatus : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
 }
}
