using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallForwardingSelectiveModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = true)]
    public string DefaultForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "playRingReminder", IsNullable = false)]
    public bool PlayRingReminder { get; set; }
    [XmlElement(ElementName = "criteriaActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation { get; set; }
 }
}
