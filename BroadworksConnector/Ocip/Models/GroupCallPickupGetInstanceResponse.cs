using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallPickupGetInstanceResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable { get; set; }
 }
}
