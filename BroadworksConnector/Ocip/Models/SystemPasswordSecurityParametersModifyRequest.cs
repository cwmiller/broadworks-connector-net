using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPasswordSecurityParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "useExistingHashing", IsNullable = false)]
    public bool UseExistingHashing { get; set; }
    [XmlElement(ElementName = "enforcePasswordChangeOnExpiry", IsNullable = false)]
    public bool EnforcePasswordChangeOnExpiry { get; set; }
 }
}
