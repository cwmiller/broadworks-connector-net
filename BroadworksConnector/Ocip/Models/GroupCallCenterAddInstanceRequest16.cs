using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Call Center instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Replaced by: GroupCallCenterAddInstanceRequest17
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterAddInstanceRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterAddInstanceRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterType Type {
            get => _type;
            set {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy {
            get => _policy;
            set {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        public bool PolicySpecified { get; set; }
        
        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        public bool EnableVideo {
            get => _enableVideo;
            set {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        public bool EnableVideoSpecified { get; set; }
        
        private int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        public int QueueLength {
            get => _queueLength;
            set {
                QueueLengthSpecified = true;
                _queueLength = value;
            }
        }

        [XmlIgnore]
        public bool QueueLengthSpecified { get; set; }
        
        private string _reportingServerName;

        [XmlElement(ElementName = "reportingServerName", IsNullable = false, Namespace = "")]
        public string ReportingServerName {
            get => _reportingServerName;
            set {
                ReportingServerNameSpecified = true;
                _reportingServerName = value;
            }
        }

        [XmlIgnore]
        public bool ReportingServerNameSpecified { get; set; }
        
        private bool _allowCallerToDialEscapeDigit;

        [XmlElement(ElementName = "allowCallerToDialEscapeDigit", IsNullable = false, Namespace = "")]
        public bool AllowCallerToDialEscapeDigit {
            get => _allowCallerToDialEscapeDigit;
            set {
                AllowCallerToDialEscapeDigitSpecified = true;
                _allowCallerToDialEscapeDigit = value;
            }
        }

        [XmlIgnore]
        public bool AllowCallerToDialEscapeDigitSpecified { get; set; }
        
        private string _escapeDigit;

        [XmlElement(ElementName = "escapeDigit", IsNullable = false, Namespace = "")]
        public string EscapeDigit {
            get => _escapeDigit;
            set {
                EscapeDigitSpecified = true;
                _escapeDigit = value;
            }
        }

        [XmlIgnore]
        public bool EscapeDigitSpecified { get; set; }
        
        private bool _resetCallStatisticsUponEntryInQueue;

        [XmlElement(ElementName = "resetCallStatisticsUponEntryInQueue", IsNullable = false, Namespace = "")]
        public bool ResetCallStatisticsUponEntryInQueue {
            get => _resetCallStatisticsUponEntryInQueue;
            set {
                ResetCallStatisticsUponEntryInQueueSpecified = true;
                _resetCallStatisticsUponEntryInQueue = value;
            }
        }

        [XmlIgnore]
        public bool ResetCallStatisticsUponEntryInQueueSpecified { get; set; }
        
        private bool _allowAgentLogoff;

        [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false, Namespace = "")]
        public bool AllowAgentLogoff {
            get => _allowAgentLogoff;
            set {
                AllowAgentLogoffSpecified = true;
                _allowAgentLogoff = value;
            }
        }

        [XmlIgnore]
        public bool AllowAgentLogoffSpecified { get; set; }
        
        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        public bool AllowCallWaitingForAgents {
            get => _allowCallWaitingForAgents;
            set {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        public bool AllowCallWaitingForAgentsSpecified { get; set; }
        
        private bool _allowCallsToAgentsInWrapUp;

        [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false, Namespace = "")]
        public bool AllowCallsToAgentsInWrapUp {
            get => _allowCallsToAgentsInWrapUp;
            set {
                AllowCallsToAgentsInWrapUpSpecified = true;
                _allowCallsToAgentsInWrapUp = value;
            }
        }

        [XmlIgnore]
        public bool AllowCallsToAgentsInWrapUpSpecified { get; set; }
        
        private bool _overrideAgentWrapUpTime;

        [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
        public bool OverrideAgentWrapUpTime {
            get => _overrideAgentWrapUpTime;
            set {
                OverrideAgentWrapUpTimeSpecified = true;
                _overrideAgentWrapUpTime = value;
            }
        }

        [XmlIgnore]
        public bool OverrideAgentWrapUpTimeSpecified { get; set; }
        
        private int _wrapUpSeconds;

        [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false, Namespace = "")]
        public int WrapUpSeconds {
            get => _wrapUpSeconds;
            set {
                WrapUpSecondsSpecified = true;
                _wrapUpSeconds = value;
            }
        }

        [XmlIgnore]
        public bool WrapUpSecondsSpecified { get; set; }
        
        private bool _forceDeliveryOfCalls;

        [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false, Namespace = "")]
        public bool ForceDeliveryOfCalls {
            get => _forceDeliveryOfCalls;
            set {
                ForceDeliveryOfCallsSpecified = true;
                _forceDeliveryOfCalls = value;
            }
        }

        [XmlIgnore]
        public bool ForceDeliveryOfCallsSpecified { get; set; }
        
        private int _forceDeliveryWaitTimeSeconds;

        [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = false, Namespace = "")]
        public int ForceDeliveryWaitTimeSeconds {
            get => _forceDeliveryWaitTimeSeconds;
            set {
                ForceDeliveryWaitTimeSecondsSpecified = true;
                _forceDeliveryWaitTimeSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ForceDeliveryWaitTimeSecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AudioFileCodec _externalPreferredAudioCodec;

        [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec ExternalPreferredAudioCodec {
            get => _externalPreferredAudioCodec;
            set {
                ExternalPreferredAudioCodecSpecified = true;
                _externalPreferredAudioCodec = value;
            }
        }

        [XmlIgnore]
        public bool ExternalPreferredAudioCodecSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AudioFileCodec _internalPreferredAudioCodec;

        [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec InternalPreferredAudioCodec {
            get => _internalPreferredAudioCodec;
            set {
                InternalPreferredAudioCodecSpecified = true;
                _internalPreferredAudioCodec = value;
            }
        }

        [XmlIgnore]
        public bool InternalPreferredAudioCodecSpecified { get; set; }
        
        private bool _playRingingWhenOfferingCall;

        [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false, Namespace = "")]
        public bool PlayRingingWhenOfferingCall {
            get => _playRingingWhenOfferingCall;
            set {
                PlayRingingWhenOfferingCallSpecified = true;
                _playRingingWhenOfferingCall = value;
            }
        }

        [XmlIgnore]
        public bool PlayRingingWhenOfferingCallSpecified { get; set; }
        
    }
}
