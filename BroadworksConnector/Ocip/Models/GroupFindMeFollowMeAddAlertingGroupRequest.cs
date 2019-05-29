using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeAddAlertingGroupRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "alertingGroupName", IsNullable = false)]
    public string AlertingGroupName { get; set; }
    [XmlElement(ElementName = "alertingGroupDescription", IsNullable = false)]
    public string AlertingGroupDescription { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false)]
    public bool UseDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
    [XmlElement(ElementName = "numberOfRings", IsNullable = false)]
    public int NumberOfRings { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
 }
}
