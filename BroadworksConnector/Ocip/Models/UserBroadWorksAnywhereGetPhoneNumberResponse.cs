using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetPhoneNumberResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false)]
    public string OutboundAlternateNumber { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "broadworksCallControl", IsNullable = false)]
    public bool BroadworksCallControl { get; set; }
    [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false)]
    public bool UseDiversionInhibitor { get; set; }
    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false)]
    public bool AnswerConfirmationRequired { get; set; }
    [XmlElement(ElementName = "criteriaTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable { get; set; }
 }
}
