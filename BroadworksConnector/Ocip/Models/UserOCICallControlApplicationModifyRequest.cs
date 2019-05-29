using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOCICallControlApplicationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "applicationIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList ApplicationIdList { get; set; }
 }
}
