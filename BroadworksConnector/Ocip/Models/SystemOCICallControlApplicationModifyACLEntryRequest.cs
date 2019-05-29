using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlApplicationModifyACLEntryRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "applicationId", IsNullable = false)]
    public string ApplicationId { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
 }
}
