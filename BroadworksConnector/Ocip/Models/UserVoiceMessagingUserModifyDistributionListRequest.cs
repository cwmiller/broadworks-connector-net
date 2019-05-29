using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyDistributionListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "listId", IsNullable = false)]
    public int ListId { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "phoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList PhoneNumberList { get; set; }
 }
}
