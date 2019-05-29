using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PriorityAlertCriteriaFromDnModify 
{
    [XmlElement(ElementName = "fromDnCriteriaSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PriorityAlertCriteriaFromDnSelection FromDnCriteriaSelection { get; set; }
    [XmlElement(ElementName = "includeAnonymousCallers", IsNullable = false)]
    public bool IncludeAnonymousCallers { get; set; }
    [XmlElement(ElementName = "includeUnavailableCallers", IsNullable = false)]
    public bool IncludeUnavailableCallers { get; set; }
    [XmlElement(ElementName = "phoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList { get; set; }
 }
}
