using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeModifyAlertingGroupRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "alertingGroupName", IsNullable = false)]
    public string AlertingGroupName { get; set; }
    [XmlElement(ElementName = "newAlertingGroupName", IsNullable = false)]
    public string NewAlertingGroupName { get; set; }
    [XmlElement(ElementName = "alertingGroupDescription", IsNullable = true)]
    public string AlertingGroupDescription { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false)]
    public bool UseDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
    [XmlElement(ElementName = "numberOfRings", IsNullable = false)]
    public int NumberOfRings { get; set; }
    [XmlElement(ElementName = "phoneNumberOrUserList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.FindMeFollowMeAlertingGroupReplacementOutgoingDNSIPURIorUserIdList PhoneNumberOrUserList { get; set; }
    [XmlElement(ElementName = "criteriaActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation { get; set; }
 }
}
