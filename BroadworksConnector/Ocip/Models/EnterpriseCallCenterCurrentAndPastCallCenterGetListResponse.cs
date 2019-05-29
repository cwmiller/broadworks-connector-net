using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public List<string> ServiceUserId { get; set; }
    [XmlElement(ElementName = "deletedServiceUserId", IsNullable = false)]
    public List<string> DeletedServiceUserId { get; set; }
 }
}
