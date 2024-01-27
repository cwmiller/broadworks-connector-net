using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Extended Call Log entry describing a placed, received, or missed call.
    /// "countryCode" is the user's country code
    /// The following time elements are represented as timestamp, i.e., the number of milliseconds
    /// since January 1, 1970, 00:00:00 GMT.
    /// "startTime" represents the time when the system sends out a call invitation message (e.g. for
    /// placed calls) or receives a call invitation message (e.g. for missed/received calls).
    /// "answerTime" represents the time when the call is answered by the terminating party.
    /// "detachedTime" represents the time when the call is successfully redirected by the system.
    /// "releaseTime" represents the time when the call is released. This time corresponds to the
    /// moment the call is released by the system, and not necessarily when one party hangs up, since this
    /// does not always mean the call is released (e.g. Emergency/911 calls).
    /// The elements "userGroupId", "userId","userPrimaryDn" and "userPrimaryExtension"
    /// are only returned when the enterprise or group level requests are used.
    /// The following elements are only used in AS data mode:
    /// callAuthorizationCode
    /// securityClassification
    /// 
    /// ExtendedMixedCallLogsEntry21sp1 version: only the ServiceInvocationDisposition21sp1 name changed.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:19389""}]")]
    public class ExtendedMixedCallLogsEntry22
    {

        protected BroadWorksConnector.Ocip.Models.CallLogsType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.CallLogsType CallLogType
        {
            get => _callLogType;
            set
            {
                CallLogTypeSpecified = true;
                _callLogType = value;
            }
        }

        [XmlIgnore]
        protected bool CallLogTypeSpecified { get; set; }

        protected string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
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
        protected bool CountryCodeSpecified { get; set; }

        protected string _callLogId;

        [XmlElement(ElementName = "callLogId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(36)]
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
        protected bool CallLogIdSpecified { get; set; }

        protected string _callId;

        [XmlElement(ElementName = "callId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool CallIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 _subscriberType;

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 SubscriberType
        {
            get => _subscriberType;
            set
            {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriberTypeSpecified { get; set; }

        protected string _dialedNumber;

        [XmlElement(ElementName = "dialedNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool DialedNumberSpecified { get; set; }

        protected string _calledNumber;

        [XmlElement(ElementName = "calledNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool CalledNumberSpecified { get; set; }

        protected string _networkTranslatedAddress;

        [XmlElement(ElementName = "networkTranslatedAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool NetworkTranslatedAddressSpecified { get; set; }

        protected string _callingAssertedNumber;

        [XmlElement(ElementName = "callingAssertedNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool CallingAssertedNumberSpecified { get; set; }

        protected string _callingPresentationNumber;

        [XmlElement(ElementName = "callingPresentationNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool CallingPresentationNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallingPresentationNumberSource _callingPresentationNumberSource;

        [XmlElement(ElementName = "callingPresentationNumberSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.CallingPresentationNumberSource CallingPresentationNumberSource
        {
            get => _callingPresentationNumberSource;
            set
            {
                CallingPresentationNumberSourceSpecified = true;
                _callingPresentationNumberSource = value;
            }
        }

        [XmlIgnore]
        protected bool CallingPresentationNumberSourceSpecified { get; set; }

        protected string _callingPresentationName;

        [XmlElement(ElementName = "callingPresentationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(80)]
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
        protected bool CallingPresentationNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PresentationIndicator _callingPresentationIndicator;

        [XmlElement(ElementName = "callingPresentationIndicator", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.PresentationIndicator CallingPresentationIndicator
        {
            get => _callingPresentationIndicator;
            set
            {
                CallingPresentationIndicatorSpecified = true;
                _callingPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool CallingPresentationIndicatorSpecified { get; set; }

        protected string _callingGroupId;

        [XmlElement(ElementName = "callingGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool CallingGroupIdSpecified { get; set; }

        protected string _calledDirectoryName;

        [XmlElement(ElementName = "calledDirectoryName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(62)]
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
        protected bool CalledDirectoryNameSpecified { get; set; }

        protected string _calledGroupId;

        [XmlElement(ElementName = "calledGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool CalledGroupIdSpecified { get; set; }

        protected string _connectedNumber;

        [XmlElement(ElementName = "connectedNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool ConnectedNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ConnectedNumberSource _connectedNumberSource;

        [XmlElement(ElementName = "connectedNumberSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.ConnectedNumberSource ConnectedNumberSource
        {
            get => _connectedNumberSource;
            set
            {
                ConnectedNumberSourceSpecified = true;
                _connectedNumberSource = value;
            }
        }

        [XmlIgnore]
        protected bool ConnectedNumberSourceSpecified { get; set; }

        protected string _connectedName;

        [XmlElement(ElementName = "connectedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(80)]
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
        protected bool ConnectedNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PresentationIndicator _connectedPresentationIndicator;

        [XmlElement(ElementName = "connectedPresentationIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.PresentationIndicator ConnectedPresentationIndicator
        {
            get => _connectedPresentationIndicator;
            set
            {
                ConnectedPresentationIndicatorSpecified = true;
                _connectedPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool ConnectedPresentationIndicatorSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkType _typeOfNetwork;

        [XmlElement(ElementName = "typeOfNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.NetworkType TypeOfNetwork
        {
            get => _typeOfNetwork;
            set
            {
                TypeOfNetworkSpecified = true;
                _typeOfNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool TypeOfNetworkSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCategory _callCategory;

        [XmlElement(ElementName = "callCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.CallCategory CallCategory
        {
            get => _callCategory;
            set
            {
                CallCategorySpecified = true;
                _callCategory = value;
            }
        }

        [XmlIgnore]
        protected bool CallCategorySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BasicCallType _basicCallType;

        [XmlElement(ElementName = "basicCallType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.BasicCallType BasicCallType
        {
            get => _basicCallType;
            set
            {
                BasicCallTypeSpecified = true;
                _basicCallType = value;
            }
        }

        [XmlIgnore]
        protected bool BasicCallTypeSpecified { get; set; }

        protected string _configurableCallType;

        [XmlElement(ElementName = "configurableCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool ConfigurableCallTypeSpecified { get; set; }

        protected string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool AlternateCallIndicatorSpecified { get; set; }

        protected string _virtualOnNetCallType;

        [XmlElement(ElementName = "virtualOnNetCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool VirtualOnNetCallTypeSpecified { get; set; }

        protected string _time;

        [XmlElement(ElementName = "time", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
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
        protected bool TimeSpecified { get; set; }

        protected string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
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
        protected bool StartTimeSpecified { get; set; }

        protected string _answerTime;

        [XmlElement(ElementName = "answerTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
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
        protected bool AnswerTimeSpecified { get; set; }

        protected string _releaseTime;

        [XmlElement(ElementName = "releaseTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
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
        protected bool ReleaseTimeSpecified { get; set; }

        protected string _detachedTime;

        [XmlElement(ElementName = "detachedTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
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
        protected bool DetachedTimeSpecified { get; set; }

        protected string _detachedAnswerTime;

        [XmlElement(ElementName = "detachedAnswerTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
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
        protected bool DetachedAnswerTimeSpecified { get; set; }

        protected string _outgoingDnis;

        [XmlElement(ElementName = "outgoingDnis", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(202)]
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
        protected bool OutgoingDnisSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1 _serviceInvocationDisposition;

        [XmlElement(ElementName = "serviceInvocationDisposition", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1 ServiceInvocationDisposition
        {
            get => _serviceInvocationDisposition;
            set
            {
                ServiceInvocationDispositionSpecified = true;
                _serviceInvocationDisposition = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInvocationDispositionSpecified { get; set; }

        protected string _serviceInvocationDialedNumber;

        [XmlElement(ElementName = "serviceInvocationDialedNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool ServiceInvocationDialedNumberSpecified { get; set; }

        protected string _serviceInvocationCalledNumber;

        [XmlElement(ElementName = "serviceInvocationCalledNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool ServiceInvocationCalledNumberSpecified { get; set; }

        protected string _serviceInvocationNetworkTranslatedAddress;

        [XmlElement(ElementName = "serviceInvocationNetworkTranslatedAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool ServiceInvocationNetworkTranslatedAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkType _serviceInvocationTypeOfNetwork;

        [XmlElement(ElementName = "serviceInvocationTypeOfNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.NetworkType ServiceInvocationTypeOfNetwork
        {
            get => _serviceInvocationTypeOfNetwork;
            set
            {
                ServiceInvocationTypeOfNetworkSpecified = true;
                _serviceInvocationTypeOfNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInvocationTypeOfNetworkSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCategory _serviceInvocationCallCategory;

        [XmlElement(ElementName = "serviceInvocationCallCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.CallCategory ServiceInvocationCallCategory
        {
            get => _serviceInvocationCallCategory;
            set
            {
                ServiceInvocationCallCategorySpecified = true;
                _serviceInvocationCallCategory = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInvocationCallCategorySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BasicCallType _serviceInvocationBasicCallType;

        [XmlElement(ElementName = "serviceInvocationBasicCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.BasicCallType ServiceInvocationBasicCallType
        {
            get => _serviceInvocationBasicCallType;
            set
            {
                ServiceInvocationBasicCallTypeSpecified = true;
                _serviceInvocationBasicCallType = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInvocationBasicCallTypeSpecified { get; set; }

        protected string _serviceInvocationConfigurableCallType;

        [XmlElement(ElementName = "serviceInvocationConfigurableCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool ServiceInvocationConfigurableCallTypeSpecified { get; set; }

        protected string _serviceInvocationAlternateCallIndicator;

        [XmlElement(ElementName = "serviceInvocationAlternateCallIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool ServiceInvocationAlternateCallIndicatorSpecified { get; set; }

        protected string _serviceInvocationVirtualOnNetCallType;

        [XmlElement(ElementName = "serviceInvocationVirtualOnNetCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool ServiceInvocationVirtualOnNetCallTypeSpecified { get; set; }

        protected string _serviceInvocationCalledDirectoryName;

        [XmlElement(ElementName = "serviceInvocationCalledDirectoryName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(62)]
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
        protected bool ServiceInvocationCalledDirectoryNameSpecified { get; set; }

        protected string _serviceInvocationCalledGroupId;

        [XmlElement(ElementName = "serviceInvocationCalledGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool ServiceInvocationCalledGroupIdSpecified { get; set; }

        protected string _redirectingNumber;

        [XmlElement(ElementName = "redirectingNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool RedirectingNumberSpecified { get; set; }

        protected string _redirectingName;

        [XmlElement(ElementName = "redirectingName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(80)]
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
        protected bool RedirectingNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RedirectingPresentationIndicator _redirectingPresentationIndicator;

        [XmlElement(ElementName = "redirectingPresentationIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        public BroadWorksConnector.Ocip.Models.RedirectingPresentationIndicator RedirectingPresentationIndicator
        {
            get => _redirectingPresentationIndicator;
            set
            {
                RedirectingPresentationIndicatorSpecified = true;
                _redirectingPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectingPresentationIndicatorSpecified { get; set; }

        protected string _redirectingReason;

        [XmlElement(ElementName = "RedirectingReason", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(20)]
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
        protected bool RedirectingReasonSpecified { get; set; }

        protected string _accountAuthorizationCode;

        [XmlElement(ElementName = "accountAuthorizationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(2)]
        [MaxLength(14)]
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
        protected bool AccountAuthorizationCodeSpecified { get; set; }

        protected string _callAuthorizationCode;

        [XmlElement(ElementName = "callAuthorizationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(2)]
        [MaxLength(14)]
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
        protected bool CallAuthorizationCodeSpecified { get; set; }

        protected string _userGroupId;

        [XmlElement(ElementName = "userGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool UserGroupIdSpecified { get; set; }

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool UserIdSpecified { get; set; }

        protected string _userPrimaryDn;

        [XmlElement(ElementName = "userPrimaryDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(23)]
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
        protected bool UserPrimaryDnSpecified { get; set; }

        protected string _userPrimaryExtension;

        [XmlElement(ElementName = "userPrimaryExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(2)]
        [MaxLength(20)]
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
        protected bool UserPrimaryExtensionSpecified { get; set; }

        protected string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool SecurityClassificationSpecified { get; set; }

        protected string _directRouteNumber;

        [XmlElement(ElementName = "directRouteNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(161)]
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
        protected bool DirectRouteNumberSpecified { get; set; }

        protected string _routeListDN;

        [XmlElement(ElementName = "routeListDN", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19389")]
        [MinLength(1)]
        [MaxLength(23)]
        public string RouteListDN
        {
            get => _routeListDN;
            set
            {
                RouteListDNSpecified = true;
                _routeListDN = value;
            }
        }

        [XmlIgnore]
        protected bool RouteListDNSpecified { get; set; }

    }
}
