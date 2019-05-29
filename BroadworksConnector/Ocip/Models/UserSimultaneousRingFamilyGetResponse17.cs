using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingFamilyGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "doNotRingIfOnCall", IsNullable = false)]
    public bool DoNotRingIfOnCall { get; set; }
    [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber { get; set; }
    [XmlElement(ElementName = "criteriaTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable { get; set; }
 }
}
