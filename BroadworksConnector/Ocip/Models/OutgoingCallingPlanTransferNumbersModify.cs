using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanTransferNumbersModify 
{
    [XmlElement(ElementName = "phoneNumber01", IsNullable = true)]
    public string PhoneNumber01 { get; set; }
    [XmlElement(ElementName = "phoneNumber02", IsNullable = true)]
    public string PhoneNumber02 { get; set; }
    [XmlElement(ElementName = "phoneNumber03", IsNullable = true)]
    public string PhoneNumber03 { get; set; }
 }
}
