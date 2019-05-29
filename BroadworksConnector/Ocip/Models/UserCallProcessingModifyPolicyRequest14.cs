using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallProcessingModifyPolicyRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
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
    [XmlElement(ElementName = "supportedMediaSetName", IsNullable = true)]
    public string SupportedMediaSetName { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false)]
    public bool UseMaxConcurrentRedirectedCalls { get; set; }
    [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false)]
    public int MaxConcurrentRedirectedCalls { get; set; }
    [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false)]
    public bool UseMaxFindMeFollowMeDepth { get; set; }
    [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false)]
    public int MaxFindMeFollowMeDepth { get; set; }
    [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false)]
    public int MaxRedirectionDepth { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false)]
    public bool UseMaxConcurrentFindMeFollowMeInvocations { get; set; }
    [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false)]
    public int MaxConcurrentFindMeFollowMeInvocations { get; set; }
 }
}
