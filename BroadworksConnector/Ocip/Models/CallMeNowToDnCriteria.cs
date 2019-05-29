using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallMeNowToDnCriteria 
{
    [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CriteriaDnSelection ToDnCriteriaSelection { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public List<string> PhoneNumber { get; set; }
 }
}
