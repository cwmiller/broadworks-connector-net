using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaTrunkGroupName : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "mode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchMode Mode { get; set; }
    [XmlElement(ElementName = "value", IsNullable = false)]
    public string Value { get; set; }
    [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false)]
    public bool IsCaseInsensitive { get; set; }
 }
}
