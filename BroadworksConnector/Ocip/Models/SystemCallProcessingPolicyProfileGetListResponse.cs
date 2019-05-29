using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callProcessingPolicyProfilesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallProcessingPolicyProfilesTable { get; set; }
 }
}
