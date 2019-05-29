using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPolycomPhoneServicesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "integratePhoneDirectoryWithBroadWorks", IsNullable = false)]
    public bool IntegratePhoneDirectoryWithBroadWorks { get; set; }
    [XmlElement(ElementName = "includeUserPersonalPhoneListInDirectory", IsNullable = false)]
    public bool IncludeUserPersonalPhoneListInDirectory { get; set; }
    [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false)]
    public bool IncludeGroupCustomContactDirectoryInDirectory { get; set; }
    [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false)]
    public string GroupCustomContactDirectory { get; set; }
 }
}
