using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingFamilyGetResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SimultaneousRingSelection IncomingCalls { get; set; }
    [XmlElement(ElementName = "phoneNumberTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PhoneNumberTable { get; set; }
 }
}
