using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaGroupCommonMultiPartPhoneListName : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "value", IsNullable = false)]
    public List<string> Value { get; set; }
    [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false)]
    public bool IsCaseInsensitive { get; set; }
 }
}
