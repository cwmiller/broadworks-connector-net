using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPolycomPhoneServicesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "includeGroupCommonPhoneListInDirectory", IsNullable = false)]
    public bool IncludeGroupCommonPhoneListInDirectory { get; set; }
    [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false)]
    public bool IncludeGroupCustomContactDirectoryInDirectory { get; set; }
    [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false)]
    public string GroupCustomContactDirectory { get; set; }
 }
}
