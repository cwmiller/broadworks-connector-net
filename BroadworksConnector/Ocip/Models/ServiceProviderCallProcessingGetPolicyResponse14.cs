using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCallProcessingGetPolicyResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    [XmlElement(ElementName = "networkUsageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection { get; set; }
    [XmlElement(ElementName = "enforceGroupCallingLineIdentityRestriction", IsNullable = false)]
    public bool EnforceGroupCallingLineIdentityRestriction { get; set; }
    [XmlElement(ElementName = "enforceEnterpriseCallingLineIdentityRestriction", IsNullable = false)]
    public bool EnforceEnterpriseCallingLineIdentityRestriction { get; set; }
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderConferenceURISettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "conferenceURI", IsNullable = false)]
    public string ConferenceURI { get; set; }
 }
}
