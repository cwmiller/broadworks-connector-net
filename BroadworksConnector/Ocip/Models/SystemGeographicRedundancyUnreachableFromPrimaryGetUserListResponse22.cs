using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable { get; set; }
    [XmlElement(ElementName = "totalNumberOfUnreachableFromPrimaryUsers", IsNullable = false)]
    public int TotalNumberOfUnreachableFromPrimaryUsers { get; set; }
 }
}
