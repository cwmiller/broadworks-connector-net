using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyGroupIdResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "error", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserMoveMessage> Error { get; set; }
    [XmlElement(ElementName = "impact", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserMoveMessage> Impact { get; set; }
 }
}
