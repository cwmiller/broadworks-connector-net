using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallGetInstanceResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "destinationPhoneNumber", IsNullable = false)]
    public List<string> DestinationPhoneNumber { get; set; }
    [XmlElement(ElementName = "isAnswerTimeoutEnabled", IsNullable = false)]
    public bool IsAnswerTimeoutEnabled { get; set; }
    [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = false)]
    public int AnswerTimeoutMinutes { get; set; }
 }
}
