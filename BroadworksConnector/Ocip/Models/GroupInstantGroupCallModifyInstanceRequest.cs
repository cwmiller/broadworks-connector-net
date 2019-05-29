using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "destinationPhoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList DestinationPhoneNumberList { get; set; }
    [XmlElement(ElementName = "isAnswerTimeoutEnabled", IsNullable = false)]
    public bool IsAnswerTimeoutEnabled { get; set; }
    [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = true)]
    public int? AnswerTimeoutMinutes { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
