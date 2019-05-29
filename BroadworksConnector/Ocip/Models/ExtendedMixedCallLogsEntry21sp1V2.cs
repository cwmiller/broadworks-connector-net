using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExtendedMixedCallLogsEntry21sp1V2 
{
    [XmlElement(ElementName = "callLogType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallLogsType CallLogType { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "callLogId", IsNullable = false)]
    public string CallLogId { get; set; }
    [XmlElement(ElementName = "callId", IsNullable = false)]
    public string CallId { get; set; }
    [XmlElement(ElementName = "subscriberType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 SubscriberType { get; set; }
    [XmlElement(ElementName = "dialedNumber", IsNullable = false)]
    public string DialedNumber { get; set; }
    [XmlElement(ElementName = "calledNumber", IsNullable = false)]
    public string CalledNumber { get; set; }
    [XmlElement(ElementName = "networkTranslatedAddress", IsNullable = false)]
    public string NetworkTranslatedAddress { get; set; }
    [XmlElement(ElementName = "callingAssertedNumber", IsNullable = false)]
    public string CallingAssertedNumber { get; set; }
    [XmlElement(ElementName = "callingPresentationNumber", IsNullable = false)]
    public string CallingPresentationNumber { get; set; }
    [XmlElement(ElementName = "callingPresentationNumberSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingPresentationNumberSource CallingPresentationNumberSource { get; set; }
    [XmlElement(ElementName = "callingPresentationName", IsNullable = false)]
    public string CallingPresentationName { get; set; }
    [XmlElement(ElementName = "callingPresentationIndicator", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PresentationIndicator CallingPresentationIndicator { get; set; }
    [XmlElement(ElementName = "callingGroupId", IsNullable = false)]
    public string CallingGroupId { get; set; }
    [XmlElement(ElementName = "calledDirectoryName", IsNullable = false)]
    public string CalledDirectoryName { get; set; }
    [XmlElement(ElementName = "calledGroupId", IsNullable = false)]
    public string CalledGroupId { get; set; }
    [XmlElement(ElementName = "connectedNumber", IsNullable = false)]
    public string ConnectedNumber { get; set; }
    [XmlElement(ElementName = "connectedNumberSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ConnectedNumberSource ConnectedNumberSource { get; set; }
    [XmlElement(ElementName = "connectedName", IsNullable = false)]
    public string ConnectedName { get; set; }
    [XmlElement(ElementName = "connectedPresentationIndicator", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PresentationIndicator ConnectedPresentationIndicator { get; set; }
    [XmlElement(ElementName = "typeOfNetwork", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkType TypeOfNetwork { get; set; }
    [XmlElement(ElementName = "callCategory", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCategory CallCategory { get; set; }
    [XmlElement(ElementName = "basicCallType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BasicCallType BasicCallType { get; set; }
    [XmlElement(ElementName = "configurableCallType", IsNullable = false)]
    public string ConfigurableCallType { get; set; }
    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false)]
    public string AlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "virtualOnNetCallType", IsNullable = false)]
    public string VirtualOnNetCallType { get; set; }
    [XmlElement(ElementName = "time", IsNullable = false)]
    public string Time { get; set; }
    [XmlElement(ElementName = "startTime", IsNullable = false)]
    public string StartTime { get; set; }
    [XmlElement(ElementName = "answerTime", IsNullable = false)]
    public string AnswerTime { get; set; }
    [XmlElement(ElementName = "releaseTime", IsNullable = false)]
    public string ReleaseTime { get; set; }
    [XmlElement(ElementName = "detachedTime", IsNullable = false)]
    public string DetachedTime { get; set; }
    [XmlElement(ElementName = "detachedAnswerTime", IsNullable = false)]
    public string DetachedAnswerTime { get; set; }
    [XmlElement(ElementName = "outgoingDnis", IsNullable = false)]
    public string OutgoingDnis { get; set; }
    [XmlElement(ElementName = "serviceInvocationDisposition", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInvocationDisposition21sp1 ServiceInvocationDisposition { get; set; }
    [XmlElement(ElementName = "serviceInvocationDialedNumber", IsNullable = false)]
    public string ServiceInvocationDialedNumber { get; set; }
    [XmlElement(ElementName = "serviceInvocationCalledNumber", IsNullable = false)]
    public string ServiceInvocationCalledNumber { get; set; }
    [XmlElement(ElementName = "serviceInvocationNetworkTranslatedAddress", IsNullable = false)]
    public string ServiceInvocationNetworkTranslatedAddress { get; set; }
    [XmlElement(ElementName = "serviceInvocationTypeOfNetwork", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkType ServiceInvocationTypeOfNetwork { get; set; }
    [XmlElement(ElementName = "serviceInvocationCallCategory", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCategory ServiceInvocationCallCategory { get; set; }
    [XmlElement(ElementName = "serviceInvocationBasicCallType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BasicCallType ServiceInvocationBasicCallType { get; set; }
    [XmlElement(ElementName = "serviceInvocationConfigurableCallType", IsNullable = false)]
    public string ServiceInvocationConfigurableCallType { get; set; }
    [XmlElement(ElementName = "serviceInvocationAlternateCallIndicator", IsNullable = false)]
    public string ServiceInvocationAlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "serviceInvocationVirtualOnNetCallType", IsNullable = false)]
    public string ServiceInvocationVirtualOnNetCallType { get; set; }
    [XmlElement(ElementName = "serviceInvocationCalledDirectoryName", IsNullable = false)]
    public string ServiceInvocationCalledDirectoryName { get; set; }
    [XmlElement(ElementName = "serviceInvocationCalledGroupId", IsNullable = false)]
    public string ServiceInvocationCalledGroupId { get; set; }
    [XmlElement(ElementName = "redirectingNumber", IsNullable = false)]
    public string RedirectingNumber { get; set; }
    [XmlElement(ElementName = "redirectingName", IsNullable = false)]
    public string RedirectingName { get; set; }
    [XmlElement(ElementName = "redirectingPresentationIndicator", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RedirectingPresentationIndicator RedirectingPresentationIndicator { get; set; }
    [XmlElement(ElementName = "RedirectingReason", IsNullable = false)]
    public string RedirectingReason { get; set; }
    [XmlElement(ElementName = "accountAuthorizationCode", IsNullable = false)]
    public string AccountAuthorizationCode { get; set; }
    [XmlElement(ElementName = "callAuthorizationCode", IsNullable = false)]
    public string CallAuthorizationCode { get; set; }
    [XmlElement(ElementName = "userGroupId", IsNullable = false)]
    public string UserGroupId { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "userPrimaryDn", IsNullable = false)]
    public string UserPrimaryDn { get; set; }
    [XmlElement(ElementName = "userPrimaryExtension", IsNullable = false)]
    public string UserPrimaryExtension { get; set; }
    [XmlElement(ElementName = "securityClassification", IsNullable = false)]
    public string SecurityClassification { get; set; }
    [XmlElement(ElementName = "directRouteNumber", IsNullable = false)]
    public string DirectRouteNumber { get; set; }
 }
}
