using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallProcessingGetPolicyResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useUserSetting", IsNullable = false)]
    public bool UseUserSetting { get; set; }
    [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false)]
    public bool UseMaxSimultaneousCalls { get; set; }
    [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false)]
    public int MaxSimultaneousCalls { get; set; }
    [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false)]
    public bool UseMaxSimultaneousVideoCalls { get; set; }
    [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false)]
    public int MaxSimultaneousVideoCalls { get; set; }
    [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false)]
    public bool UseMaxCallTimeForAnsweredCalls { get; set; }
    [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false)]
    public int MaxCallTimeForAnsweredCallsMinutes { get; set; }
    [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false)]
    public bool UseMaxCallTimeForUnansweredCalls { get; set; }
    [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false)]
    public int MaxCallTimeForUnansweredCallsMinutes { get; set; }
    [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection { get; set; }
    [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false)]
    public string SupportedMediaSetName { get; set; }
 }
}
