using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityMobileIdentityConsolidatedDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "mobileNumber", IsNullable = false)]
    public string MobileNumber { get; set; }
    [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false)]
    public bool DeleteExistingDevices { get; set; }
 }
}
