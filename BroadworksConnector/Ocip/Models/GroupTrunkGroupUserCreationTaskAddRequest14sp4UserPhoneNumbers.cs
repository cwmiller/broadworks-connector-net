using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskAddRequest14sp4UserPhoneNumbers 
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public List<string> PhoneNumber { get; set; }
    [XmlElement(ElementName = "dnRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DNRange> DnRange { get; set; }
 }
}
