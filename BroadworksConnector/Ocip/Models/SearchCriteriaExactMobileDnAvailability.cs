using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactMobileDnAvailability : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "available", IsNullable = false)]
    public bool Available { get; set; }
 }
}
