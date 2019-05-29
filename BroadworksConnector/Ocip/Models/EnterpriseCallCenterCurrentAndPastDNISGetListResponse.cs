using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCurrentAndPastDNISGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public List<string> Name { get; set; }
    [XmlElement(ElementName = "deletedName", IsNullable = false)]
    public List<string> DeletedName { get; set; }
 }
}
