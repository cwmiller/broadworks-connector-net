using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDnGetUtilizationRequest14sp3 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
 }
}
