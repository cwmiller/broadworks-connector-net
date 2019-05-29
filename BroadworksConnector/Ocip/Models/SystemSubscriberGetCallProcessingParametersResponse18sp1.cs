using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberGetCallProcessingParametersResponse18sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    [XmlElement(ElementName = "incomingCallToUserAliasMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IncomingCallToUserAliasMode IncomingCallToUserAliasMode { get; set; }
    [XmlElement(ElementName = "bypassTerminationLoopDetection", IsNullable = false)]
    public bool BypassTerminationLoopDetection { get; set; }
    [XmlElement(ElementName = "honorCLIDBlockingForEmergencyCalls", IsNullable = false)]
    public bool HonorCLIDBlockingForEmergencyCalls { get; set; }
    [XmlElement(ElementName = "useUnicodeIdentityName", IsNullable = false)]
    public bool UseUnicodeIdentityName { get; set; }
 }
}
