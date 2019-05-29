using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPortalPasscodeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "oldPasscode", IsNullable = false)]
    public string OldPasscode { get; set; }
    [XmlElement(ElementName = "newPasscode", IsNullable = false)]
    public string NewPasscode { get; set; }
 }
}
