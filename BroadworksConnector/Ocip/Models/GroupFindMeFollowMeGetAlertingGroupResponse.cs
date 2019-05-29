using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeGetAlertingGroupResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "alertingGroupDescription", IsNullable = false)]
    public string AlertingGroupDescription { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false)]
    public bool UseDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
    [XmlElement(ElementName = "numberOfRings", IsNullable = false)]
    public int NumberOfRings { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public List<string> PhoneNumber { get; set; }
    [XmlElement(ElementName = "userTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable { get; set; }
    [XmlElement(ElementName = "criteriaTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable { get; set; }
 }
}
