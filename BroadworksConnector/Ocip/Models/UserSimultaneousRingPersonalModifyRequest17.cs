using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingPersonalModifyRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "doNotRingIfOnCall", IsNullable = false)]
    public bool DoNotRingIfOnCall { get; set; }
    [XmlElement(ElementName = "simultaneousRingNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.SimultaneousRingReplacementNumberList SimultaneousRingNumberList { get; set; }
    [XmlElement(ElementName = "criteriaActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation { get; set; }
 }
}
