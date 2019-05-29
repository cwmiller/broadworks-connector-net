using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "userType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserType UserType { get; set; }
 }
}
