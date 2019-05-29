using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFileRepositoryDeviceUserGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable FileRepositoryUserTable { get; set; }
 }
}
