using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable { get; set; }
 }
}
