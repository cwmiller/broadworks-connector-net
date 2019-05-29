using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallMeNowToDnCriteriaModify 
{
    [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CriteriaDnSelection ToDnCriteriaSelection { get; set; }
    [XmlElement(ElementName = "phoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList { get; set; }
 }
}
