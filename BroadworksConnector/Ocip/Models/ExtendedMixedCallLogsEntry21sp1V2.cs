using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class ExtendedMixedCallLogsEntry21sp1V2
    {
        private BroadworksConnector.Ocip.Models.CallLogsType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallLogsType CallLogType
        {
            get => _callLogType;
            set
            {
                CallLogTypeSpecified = true;
                _callLogType = value;
            }
        }

        [XmlIgnore]
        public bool CallLogTypeSpecified { get; set; }
        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }
        private string _callLogId;

        [XmlElement(ElementName = "callLogId", IsNullable = false, Namespace = "")]
        public string CallLogId
        {
            get => _callLogId;
            set
            {
                CallLogIdSpecified = true;
                _callLogId = value;
            }
        }

        [XmlIgnore]
        public bool CallLogIdSpecified { get; set; }
        private string _callId;

        [XmlElement(ElementName = "callId", IsNullable = false, Namespace = "")]
        public string CallId
        {
            get => _callId;
            set
            {
                CallIdSpecified = true;
                _callId = value;
            }
        }

        [XmlIgnore]
        public bool CallIdSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 _subscriberType;

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 SubscriberType
        {
            get => _subscriberType;
            set
            {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        public bool SubscriberTypeSpecified { get; set; }
        private string _dialedNumber;

        [XmlElement(ElementName = "dialedNumber", IsNullable = false, Namespace = "")]
        public string DialedNumber
        {
            get => _dialedNumber;
            set
            {
                DialedNumberSpecified = true;
                _dialedNumber = value;
            }
        }

        [XmlIgnore]
        public bool DialedNumberSpecified { get; set; }
        private string _calledNumber;

        [XmlElement(ElementName = "calledNumber", IsNullable = false, Namespace = "")]
        public string CalledNumber
        {
            get => _calledNumber;
            set
            {
                CalledNumberSpecified = true;
                _calledNumber = value;
            }
        }

        [XmlIgnore]
        public bool CalledNumberSpecified { get; set; }
        private string _networkTranslatedAddress;

        [XmlElement(ElementName = "networkTranslatedAddress", IsNullable = false, Namespace = "")]
        public string NetworkTranslatedAddress
        {
            get => _networkTranslatedAddress;
            set
            {
                NetworkTranslatedAddressSpecified = true;
                _networkTranslatedAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetworkTranslatedAddressSpecified { get; set; }
        private string _callingAssertedNumber;

        [XmlElement(ElementName = "callingAssertedNumber", IsNullable = false, Namespace = "")]
        public string CallingAssertedNumber
        {
            get => _callingAssertedNumber;
            set
            {
                CallingAssertedNumberSpecified = true;
                _callingAssertedNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallingAssertedNumberSpecified { get; set; }
        private string _callingPresentationNumber;

        [XmlElement(ElementName = "callingPresentationNumber", IsNullable = false, Namespace = "")]
        public string CallingPresentationNumber
        {
            get => _callingPresentationNumber;
            set
            {
                CallingPresentationNumberSpecified = true;
                _callingPresentationNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallingPresentationNumberSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallingPresentationNumberSource _callingPresentationNumberSource;

        [XmlElement(ElementName = "callingPresentationNumberSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallingPresentationNumberSource CallingPresentationNumberSource
        {
            get => _callingPresentationNumberSource;
            set
            {
                CallingPresentationNumberSourceSpecified = true;
                _callingPresentationNumberSource = value;
            }
        }

        [XmlIgnore]
        public bool CallingPresentationNumberSourceSpecified { get; set; }
        private string _callingPresentationName;

        [XmlElement(ElementName = "callingPresentationName", IsNullable = false, Namespace = "")]
        public string CallingPresentationName
        {
            get => _callingPresentationName;
            set
            {
                CallingPresentationNameSpecified = true;
                _callingPresentationName = value;
            }
        }

        [XmlIgnore]
        public bool CallingPresentationNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.PresentationIndicator _callingPresentationIndicator;

        [XmlElement(ElementName = "callingPresentationIndicator", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.PresentationIndicator CallingPresentationIndicator
        {
            get => _callingPresentationIndicator;
            set
            {
                CallingPresentationIndicatorSpecified = true;
                _callingPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        public bool CallingPresentationIndicatorSpecified { get; set; }
        private string _callingGroupId;

        [XmlElement(ElementName = "callingGroupId", IsNullable = false, Namespace = "")]
        public string CallingGroupId
        {
            get => _callingGroupId;
            set
            {
                CallingGroupIdSpecified = true;
                _callingGroupId = value;
            }
        }

        [XmlIgnore]
        public bool CallingGroupIdSpecified { get; set; }
        private string _calledDirectoryName;

        [XmlElement(ElementName = "calledDirectoryName", IsNullable = false, Namespace = "")]
        public string CalledDirectoryName
        {
            get => _calledDirectoryName;
            set
            {
                CalledDirectoryNameSpecified = true;
                _calledDirectoryName = value;
            }
        }

        [XmlIgnore]
        public bool CalledDirectoryNameSpecified { get; set; }
        private string _calledGroupId;

        [XmlElement(ElementName = "calledGroupId", IsNullable = false, Namespace = "")]
        public string CalledGroupId
        {
            get => _calledGroupId;
            set
            {
                CalledGroupIdSpecified = true;
                _calledGroupId = value;
            }
        }

        [XmlIgnore]
        public bool CalledGroupIdSpecified { get; set; }
        private string _connectedNumber;

        [XmlElement(ElementName = "connectedNumber", IsNullable = false, Namespace = "")]
        public string ConnectedNumber
        {
            get => _connectedNumber;
            set
            {
                ConnectedNumberSpecified = true;
                _connectedNumber = value;
            }
        }

        [XmlIgnore]
        public bool ConnectedNumberSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ConnectedNumberSource _connectedNumberSource;

        [XmlElement(ElementName = "connectedNumberSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ConnectedNumberSource ConnectedNumberSource
        {
            get => _connectedNumberSource;
            set
            {
                ConnectedNumberSourceSpecified = true;
                _connectedNumberSource = value;
            }
        }

        [XmlIgnore]
        public bool ConnectedNumberSourceSpecified { get; set; }
        private string _connectedName;

        [XmlElement(ElementName = "connectedName", IsNullable = false, Namespace = "")]
        public string ConnectedName
        {
            get => _connectedName;
            set
            {
                ConnectedNameSpecified = true;
                _connectedName = value;
            }
        }

        [XmlIgnore]
        public bool ConnectedNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.PresentationIndicator _connectedPresentationIndicator;

        [XmlElement(ElementName = "connectedPresentationIndicator", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.PresentationIndicator ConnectedPresentationIndicator
        {
            get => _connectedPresentationIndicator;
            set
            {
                ConnectedPresentationIndicatorSpecified = true;
                _connectedPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        public bool ConnectedPresentationIndicatorSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.NetworkType _typeOfNetwork;

        [XmlElement(ElementName = "typeOfNetwork", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.NetworkType TypeOfNetwork
        {
            get => _typeOfNetwork;
            set
            {
                TypeOfNetworkSpecified = true;
                _typeOfNetwork = value;
            }
        }

        [XmlIgnore]
        public bool TypeOfNetworkSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCategory _callCategory;

        [XmlElement(ElementName = "callCategory", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCategory CallCategory
        {
            get => _callCategory;
            set
            {
                CallCategorySpecified = true;
                _callCategory = value;
            }
        }

        [XmlIgnore]
        public bool CallCategorySpecified { get; set; }
        private BroadworksConnector.Ocip.Models.BasicCallType _basicCallType;

        [XmlElement(ElementName = "basicCallType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.BasicCallType BasicCallType
        {
            get => _basicCallType;
            set
            {
                BasicCallTypeSpecified = true;
                _basicCallType = value;
            }
        }

        [XmlIgnore]
        public bool BasicCallTypeSpecified { get; set; }
        private string _configurableCallType;

        [XmlElement(ElementName = "configurableCallType", IsNullable = false, Namespace = "")]
        public string ConfigurableCallType
        {
            get => _configurableCallType;
            set
            {
                ConfigurableCallTypeSpecified = true;
                _configurableCallType = value;
            }
        }

        [XmlIgnore]
        public bool ConfigurableCallTypeSpecified { get; set; }
        private string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        public string AlternateCallIndicator
        {
            get => _alternateCallIndicator;
            set
            {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCallIndicatorSpecified { get; set; }
        private string _virtualOnNetCallType;

        [XmlElement(ElementName = "virtualOnNetCallType", IsNullable = false, Namespace = "")]
        public string VirtualOnNetCallType
        {
            get => _virtualOnNetCallType;
            set
            {
                VirtualOnNetCallTypeSpecified = true;
                _virtualOnNetCallType = value;
            }
        }

        [XmlIgnore]
        public bool VirtualOnNetCallTypeSpecified { get; set; }
        private string _time;

        [XmlElement(ElementName = "time", IsNullable = false, Namespace = "")]
        public string Time
        {
            get => _time;
            set
            {
                TimeSpecified = true;
                _time = value;
            }
        }

        [XmlIgnore]
        public bool TimeSpecified { get; set; }
        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        public string StartTime
        {
            get => _startTime;
            set
            {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified { get; set; }
        private string _answerTime;

        [XmlElement(ElementName = "answerTime", IsNullable = false, Namespace = "")]
        public string AnswerTime
        {
            get => _answerTime;
            set
            {
                AnswerTimeSpecified = true;
                _answerTime = value;
            }
        }

        [XmlIgnore]
        public bool AnswerTimeSpecified { get; set; }
        private string _releaseTime;

        [XmlElement(ElementName = "releaseTime", IsNullable = false, Namespace = "")]
        public string ReleaseTime
        {
            get => _releaseTime;
            set
            {
                ReleaseTimeSpecified = true;
                _releaseTime = value;
            }
        }

        [XmlIgnore]
        public bool ReleaseTimeSpecified { get; set; }
        private string _detachedTime;

        [XmlElement(ElementName = "detachedTime", IsNullable = false, Namespace = "")]
        public string DetachedTime
        {
            get => _detachedTime;
            set
            {
                DetachedTimeSpecified = true;
                _detachedTime = value;
            }
        }

        [XmlIgnore]
        public bool DetachedTimeSpecified { get; set; }
        private string _detachedAnswerTime;

        [XmlElement(ElementName = "detachedAnswerTime", IsNullable = false, Namespace = "")]
        public string DetachedAnswerTime
        {
            get => _detachedAnswerTime;
            set
            {
                DetachedAnswerTimeSpecified = true;
                _detachedAnswerTime = value;
            }
        }

        [XmlIgnore]
        public bool DetachedAnswerTimeSpecified { get; set; }
        private string _outgoingDnis;

        [XmlElement(ElementName = "outgoingDnis", IsNullable = false, Namespace = "")]
        public string OutgoingDnis
        {
            get => _outgoingDnis;
            set
            {
                OutgoingDnisSpecified = true;
                _outgoingDnis = value;
            }
        }

        [XmlIgnore]
        public bool OutgoingDnisSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ServiceInvocationDisposition21sp1 _serviceInvocationDisposition;

        [XmlElement(ElementName = "serviceInvocationDisposition", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ServiceInvocationDisposition21sp1 ServiceInvocationDisposition
        {
            get => _serviceInvocationDisposition;
            set
            {
                ServiceInvocationDispositionSpecified = true;
                _serviceInvocationDisposition = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationDispositionSpecified { get; set; }
        private string _serviceInvocationDialedNumber;

        [XmlElement(ElementName = "serviceInvocationDialedNumber", IsNullable = false, Namespace = "")]
        public string ServiceInvocationDialedNumber
        {
            get => _serviceInvocationDialedNumber;
            set
            {
                ServiceInvocationDialedNumberSpecified = true;
                _serviceInvocationDialedNumber = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationDialedNumberSpecified { get; set; }
        private string _serviceInvocationCalledNumber;

        [XmlElement(ElementName = "serviceInvocationCalledNumber", IsNullable = false, Namespace = "")]
        public string ServiceInvocationCalledNumber
        {
            get => _serviceInvocationCalledNumber;
            set
            {
                ServiceInvocationCalledNumberSpecified = true;
                _serviceInvocationCalledNumber = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationCalledNumberSpecified { get; set; }
        private string _serviceInvocationNetworkTranslatedAddress;

        [XmlElement(ElementName = "serviceInvocationNetworkTranslatedAddress", IsNullable = false, Namespace = "")]
        public string ServiceInvocationNetworkTranslatedAddress
        {
            get => _serviceInvocationNetworkTranslatedAddress;
            set
            {
                ServiceInvocationNetworkTranslatedAddressSpecified = true;
                _serviceInvocationNetworkTranslatedAddress = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationNetworkTranslatedAddressSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.NetworkType _serviceInvocationTypeOfNetwork;

        [XmlElement(ElementName = "serviceInvocationTypeOfNetwork", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.NetworkType ServiceInvocationTypeOfNetwork
        {
            get => _serviceInvocationTypeOfNetwork;
            set
            {
                ServiceInvocationTypeOfNetworkSpecified = true;
                _serviceInvocationTypeOfNetwork = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationTypeOfNetworkSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCategory _serviceInvocationCallCategory;

        [XmlElement(ElementName = "serviceInvocationCallCategory", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCategory ServiceInvocationCallCategory
        {
            get => _serviceInvocationCallCategory;
            set
            {
                ServiceInvocationCallCategorySpecified = true;
                _serviceInvocationCallCategory = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationCallCategorySpecified { get; set; }
        private BroadworksConnector.Ocip.Models.BasicCallType _serviceInvocationBasicCallType;

        [XmlElement(ElementName = "serviceInvocationBasicCallType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.BasicCallType ServiceInvocationBasicCallType
        {
            get => _serviceInvocationBasicCallType;
            set
            {
                ServiceInvocationBasicCallTypeSpecified = true;
                _serviceInvocationBasicCallType = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationBasicCallTypeSpecified { get; set; }
        private string _serviceInvocationConfigurableCallType;

        [XmlElement(ElementName = "serviceInvocationConfigurableCallType", IsNullable = false, Namespace = "")]
        public string ServiceInvocationConfigurableCallType
        {
            get => _serviceInvocationConfigurableCallType;
            set
            {
                ServiceInvocationConfigurableCallTypeSpecified = true;
                _serviceInvocationConfigurableCallType = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationConfigurableCallTypeSpecified { get; set; }
        private string _serviceInvocationAlternateCallIndicator;

        [XmlElement(ElementName = "serviceInvocationAlternateCallIndicator", IsNullable = false, Namespace = "")]
        public string ServiceInvocationAlternateCallIndicator
        {
            get => _serviceInvocationAlternateCallIndicator;
            set
            {
                ServiceInvocationAlternateCallIndicatorSpecified = true;
                _serviceInvocationAlternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationAlternateCallIndicatorSpecified { get; set; }
        private string _serviceInvocationVirtualOnNetCallType;

        [XmlElement(ElementName = "serviceInvocationVirtualOnNetCallType", IsNullable = false, Namespace = "")]
        public string ServiceInvocationVirtualOnNetCallType
        {
            get => _serviceInvocationVirtualOnNetCallType;
            set
            {
                ServiceInvocationVirtualOnNetCallTypeSpecified = true;
                _serviceInvocationVirtualOnNetCallType = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationVirtualOnNetCallTypeSpecified { get; set; }
        private string _serviceInvocationCalledDirectoryName;

        [XmlElement(ElementName = "serviceInvocationCalledDirectoryName", IsNullable = false, Namespace = "")]
        public string ServiceInvocationCalledDirectoryName
        {
            get => _serviceInvocationCalledDirectoryName;
            set
            {
                ServiceInvocationCalledDirectoryNameSpecified = true;
                _serviceInvocationCalledDirectoryName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationCalledDirectoryNameSpecified { get; set; }
        private string _serviceInvocationCalledGroupId;

        [XmlElement(ElementName = "serviceInvocationCalledGroupId", IsNullable = false, Namespace = "")]
        public string ServiceInvocationCalledGroupId
        {
            get => _serviceInvocationCalledGroupId;
            set
            {
                ServiceInvocationCalledGroupIdSpecified = true;
                _serviceInvocationCalledGroupId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInvocationCalledGroupIdSpecified { get; set; }
        private string _redirectingNumber;

        [XmlElement(ElementName = "redirectingNumber", IsNullable = false, Namespace = "")]
        public string RedirectingNumber
        {
            get => _redirectingNumber;
            set
            {
                RedirectingNumberSpecified = true;
                _redirectingNumber = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingNumberSpecified { get; set; }
        private string _redirectingName;

        [XmlElement(ElementName = "redirectingName", IsNullable = false, Namespace = "")]
        public string RedirectingName
        {
            get => _redirectingName;
            set
            {
                RedirectingNameSpecified = true;
                _redirectingName = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.RedirectingPresentationIndicator _redirectingPresentationIndicator;

        [XmlElement(ElementName = "redirectingPresentationIndicator", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.RedirectingPresentationIndicator RedirectingPresentationIndicator
        {
            get => _redirectingPresentationIndicator;
            set
            {
                RedirectingPresentationIndicatorSpecified = true;
                _redirectingPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingPresentationIndicatorSpecified { get; set; }
        private string _redirectingReason;

        [XmlElement(ElementName = "RedirectingReason", IsNullable = false, Namespace = "")]
        public string RedirectingReason
        {
            get => _redirectingReason;
            set
            {
                RedirectingReasonSpecified = true;
                _redirectingReason = value;
            }
        }

        [XmlIgnore]
        public bool RedirectingReasonSpecified { get; set; }
        private string _accountAuthorizationCode;

        [XmlElement(ElementName = "accountAuthorizationCode", IsNullable = false, Namespace = "")]
        public string AccountAuthorizationCode
        {
            get => _accountAuthorizationCode;
            set
            {
                AccountAuthorizationCodeSpecified = true;
                _accountAuthorizationCode = value;
            }
        }

        [XmlIgnore]
        public bool AccountAuthorizationCodeSpecified { get; set; }
        private string _callAuthorizationCode;

        [XmlElement(ElementName = "callAuthorizationCode", IsNullable = false, Namespace = "")]
        public string CallAuthorizationCode
        {
            get => _callAuthorizationCode;
            set
            {
                CallAuthorizationCodeSpecified = true;
                _callAuthorizationCode = value;
            }
        }

        [XmlIgnore]
        public bool CallAuthorizationCodeSpecified { get; set; }
        private string _userGroupId;

        [XmlElement(ElementName = "userGroupId", IsNullable = false, Namespace = "")]
        public string UserGroupId
        {
            get => _userGroupId;
            set
            {
                UserGroupIdSpecified = true;
                _userGroupId = value;
            }
        }

        [XmlIgnore]
        public bool UserGroupIdSpecified { get; set; }
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        private string _userPrimaryDn;

        [XmlElement(ElementName = "userPrimaryDn", IsNullable = false, Namespace = "")]
        public string UserPrimaryDn
        {
            get => _userPrimaryDn;
            set
            {
                UserPrimaryDnSpecified = true;
                _userPrimaryDn = value;
            }
        }

        [XmlIgnore]
        public bool UserPrimaryDnSpecified { get; set; }
        private string _userPrimaryExtension;

        [XmlElement(ElementName = "userPrimaryExtension", IsNullable = false, Namespace = "")]
        public string UserPrimaryExtension
        {
            get => _userPrimaryExtension;
            set
            {
                UserPrimaryExtensionSpecified = true;
                _userPrimaryExtension = value;
            }
        }

        [XmlIgnore]
        public bool UserPrimaryExtensionSpecified { get; set; }
        private string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        public string SecurityClassification
        {
            get => _securityClassification;
            set
            {
                SecurityClassificationSpecified = true;
                _securityClassification = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationSpecified { get; set; }
        private string _directRouteNumber;

        [XmlElement(ElementName = "directRouteNumber", IsNullable = false, Namespace = "")]
        public string DirectRouteNumber
        {
            get => _directRouteNumber;
            set
            {
                DirectRouteNumberSpecified = true;
                _directRouteNumber = value;
            }
        }

        [XmlIgnore]
        public bool DirectRouteNumberSpecified { get; set; }
    }
}
