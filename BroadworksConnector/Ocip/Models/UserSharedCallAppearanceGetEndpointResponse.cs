using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSharedCallAppearanceGetEndpointResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "allowOrigination", IsNullable = false)]
    public bool AllowOrigination { get; set; }
    [XmlElement(ElementName = "allowTermination", IsNullable = false)]
    public bool AllowTermination { get; set; }
 }
}
