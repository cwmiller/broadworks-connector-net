using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConnectedLineIdentificationPresentationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enforceUserServiceAssignment", IsNullable = false)]
    public bool EnforceUserServiceAssignment { get; set; }
 }
}
