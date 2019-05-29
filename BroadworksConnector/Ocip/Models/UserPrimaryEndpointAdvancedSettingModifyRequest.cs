using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrimaryEndpointAdvancedSettingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "allowOrigination", IsNullable = false)]
    public bool AllowOrigination { get; set; }
    [XmlElement(ElementName = "allowTermination", IsNullable = false)]
    public bool AllowTermination { get; set; }
    [XmlElement(ElementName = "allowVideo", IsNullable = false)]
    public bool AllowVideo { get; set; }
 }
}
