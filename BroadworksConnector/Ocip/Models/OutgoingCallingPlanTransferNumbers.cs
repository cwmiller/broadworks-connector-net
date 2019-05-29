using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanTransferNumbers 
{
    [XmlElement(ElementName = "phoneNumber01", IsNullable = false)]
    public string PhoneNumber01 { get; set; }
    [XmlElement(ElementName = "phoneNumber02", IsNullable = false)]
    public string PhoneNumber02 { get; set; }
    [XmlElement(ElementName = "phoneNumber03", IsNullable = false)]
    public string PhoneNumber03 { get; set; }
 }
}
