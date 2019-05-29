using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactHuntPolicy : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "huntPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HuntPolicy HuntPolicy { get; set; }
 }
}
