using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetInstancePagedSortedResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false)]
    public string RecallAlternateUserId { get; set; }
    [XmlElement(ElementName = "recallTo", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallParkRecallTo RecallTo { get; set; }
    [XmlElement(ElementName = "userTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable { get; set; }
 }
}
