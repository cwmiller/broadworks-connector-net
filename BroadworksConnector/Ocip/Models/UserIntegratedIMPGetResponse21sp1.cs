using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserIntegratedIMPGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "impId", IsNullable = false)]
    public string ImpId { get; set; }
    [XmlElement(ElementName = "isAlternateImpId", IsNullable = false)]
    public bool IsAlternateImpId { get; set; }
 }
}
