using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserIntegratedIMPModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "impId", IsNullable = false)]
    public string ImpId { get; set; }
    [XmlElement(ElementName = "isAlternateImpId", IsNullable = false)]
    public bool IsAlternateImpId { get; set; }
 }
}
