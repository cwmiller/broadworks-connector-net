using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCustomContactDirectory : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "customContactDirectoryName", IsNullable = false)]
    public string CustomContactDirectoryName { get; set; }
 }
}
