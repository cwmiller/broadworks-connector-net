using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactPortNumber : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
 }
}
