using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushToTalkGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false)]
    public bool AllowAutoAnswer { get; set; }
    [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection { get; set; }
    [XmlElement(ElementName = "accessListSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection { get; set; }
    [XmlElement(ElementName = "selectedUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SelectedUserTable { get; set; }
 }
}
