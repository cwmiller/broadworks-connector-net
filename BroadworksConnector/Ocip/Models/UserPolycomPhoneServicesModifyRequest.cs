using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPolycomPhoneServicesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "integratePhoneDirectoryWithBroadWorks", IsNullable = false)]
    public bool IntegratePhoneDirectoryWithBroadWorks { get; set; }
    [XmlElement(ElementName = "includeUserPersonalPhoneListInDirectory", IsNullable = false)]
    public bool IncludeUserPersonalPhoneListInDirectory { get; set; }
    [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false)]
    public bool IncludeGroupCustomContactDirectoryInDirectory { get; set; }
    [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = true)]
    public string GroupCustomContactDirectory { get; set; }
 }
}
