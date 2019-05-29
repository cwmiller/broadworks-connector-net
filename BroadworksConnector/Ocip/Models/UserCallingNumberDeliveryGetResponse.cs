using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallingNumberDeliveryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false)]
    public bool IsActiveForExternalCalls { get; set; }
    [XmlElement(ElementName = "isActiveForInternalCalls", IsNullable = false)]
    public bool IsActiveForInternalCalls { get; set; }
 }
}
