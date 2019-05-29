using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConnectedLineIdentificationPresentationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enforceUserServiceAssignment", IsNullable = false)]
    public bool EnforceUserServiceAssignment { get; set; }
 }
}
