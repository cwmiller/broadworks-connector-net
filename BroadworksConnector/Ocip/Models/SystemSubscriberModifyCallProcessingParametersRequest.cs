using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberModifyCallProcessingParametersRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userCallingLineIdSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemUserCallingLineIdSelection UserCallingLineIdSelection { get; set; }
    [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false)]
    public bool IsExtendedCallingLineIdActive { get; set; }
    [XmlElement(ElementName = "isRingTimeOutActive", IsNullable = false)]
    public bool IsRingTimeOutActive { get; set; }
    [XmlElement(ElementName = "ringTimeoutSeconds", IsNullable = false)]
    public int RingTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "allowEmergencyRemoteOfficeOriginations", IsNullable = false)]
    public bool AllowEmergencyRemoteOfficeOriginations { get; set; }
    [XmlElement(ElementName = "maxNoAnswerNumberOfRings", IsNullable = false)]
    public int MaxNoAnswerNumberOfRings { get; set; }
 }
}
