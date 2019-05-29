using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushToTalkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false)]
    public bool AllowAutoAnswer { get; set; }
    [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection { get; set; }
    [XmlElement(ElementName = "accessListSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection { get; set; }
    [XmlElement(ElementName = "selectedUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList SelectedUserIdList { get; set; }
 }
}
