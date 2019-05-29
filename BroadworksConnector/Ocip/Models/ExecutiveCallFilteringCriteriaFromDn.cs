using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExecutiveCallFilteringCriteriaFromDn 
{
    [XmlElement(ElementName = "fromDnCriteriaSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaDnSelection FromDnCriteriaSelection { get; set; }
    [XmlElement(ElementName = "includeAnonymousCallers", IsNullable = false)]
    public bool IncludeAnonymousCallers { get; set; }
    [XmlElement(ElementName = "includeUnavailableCallers", IsNullable = false)]
    public bool IncludeUnavailableCallers { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public List<string> PhoneNumber { get; set; }
 }
}
