using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDnActivation : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "activated", IsNullable = false)]
    public bool Activated { get; set; }
 }
}
