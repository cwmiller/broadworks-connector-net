using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallProcessingGetPolicyRequest14.
        /// <see cref="SystemCallProcessingGetPolicyRequest14"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingGetPolicyResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _useMaxSimultaneousCalls;

        [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
        public bool UseMaxSimultaneousCalls {
            get => _useMaxSimultaneousCalls;
            set {
                UseMaxSimultaneousCallsSpecified = true;
                _useMaxSimultaneousCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxSimultaneousCallsSpecified { get; set; }
        
        private int _maxSimultaneousCalls;

        [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
        public int MaxSimultaneousCalls {
            get => _maxSimultaneousCalls;
            set {
                MaxSimultaneousCallsSpecified = true;
                _maxSimultaneousCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxSimultaneousCallsSpecified { get; set; }
        
        private bool _useMaxSimultaneousVideoCalls;

        [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        public bool UseMaxSimultaneousVideoCalls {
            get => _useMaxSimultaneousVideoCalls;
            set {
                UseMaxSimultaneousVideoCallsSpecified = true;
                _useMaxSimultaneousVideoCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxSimultaneousVideoCallsSpecified { get; set; }
        
        private int _maxSimultaneousVideoCalls;

        [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        public int MaxSimultaneousVideoCalls {
            get => _maxSimultaneousVideoCalls;
            set {
                MaxSimultaneousVideoCallsSpecified = true;
                _maxSimultaneousVideoCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxSimultaneousVideoCallsSpecified { get; set; }
        
        private bool _useMaxCallTimeForAnsweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false, Namespace = "")]
        public bool UseMaxCallTimeForAnsweredCalls {
            get => _useMaxCallTimeForAnsweredCalls;
            set {
                UseMaxCallTimeForAnsweredCallsSpecified = true;
                _useMaxCallTimeForAnsweredCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxCallTimeForAnsweredCallsSpecified { get; set; }
        
        private int _maxCallTimeForAnsweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false, Namespace = "")]
        public int MaxCallTimeForAnsweredCallsMinutes {
            get => _maxCallTimeForAnsweredCallsMinutes;
            set {
                MaxCallTimeForAnsweredCallsMinutesSpecified = true;
                _maxCallTimeForAnsweredCallsMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxCallTimeForAnsweredCallsMinutesSpecified { get; set; }
        
        private bool _useMaxCallTimeForUnansweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false, Namespace = "")]
        public bool UseMaxCallTimeForUnansweredCalls {
            get => _useMaxCallTimeForUnansweredCalls;
            set {
                UseMaxCallTimeForUnansweredCallsSpecified = true;
                _useMaxCallTimeForUnansweredCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxCallTimeForUnansweredCallsSpecified { get; set; }
        
        private int _maxCallTimeForUnansweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false, Namespace = "")]
        public int MaxCallTimeForUnansweredCallsMinutes {
            get => _maxCallTimeForUnansweredCallsMinutes;
            set {
                MaxCallTimeForUnansweredCallsMinutesSpecified = true;
                _maxCallTimeForUnansweredCallsMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxCallTimeForUnansweredCallsMinutesSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

        [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection {
            get => _mediaPolicySelection;
            set {
                MediaPolicySelectionSpecified = true;
                _mediaPolicySelection = value;
            }
        }

        [XmlIgnore]
        public bool MediaPolicySelectionSpecified { get; set; }
        
        private string _supportedMediaSetName;

        [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false, Namespace = "")]
        public string SupportedMediaSetName {
            get => _supportedMediaSetName;
            set {
                SupportedMediaSetNameSpecified = true;
                _supportedMediaSetName = value;
            }
        }

        [XmlIgnore]
        public bool SupportedMediaSetNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.NetworkUsageSelection _networkUsageSelection;

        [XmlElement(ElementName = "networkUsageSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection {
            get => _networkUsageSelection;
            set {
                NetworkUsageSelectionSpecified = true;
                _networkUsageSelection = value;
            }
        }

        [XmlIgnore]
        public bool NetworkUsageSelectionSpecified { get; set; }
        
        private bool _enforceGroupCallingLineIdentityRestriction;

        [XmlElement(ElementName = "enforceGroupCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
        public bool EnforceGroupCallingLineIdentityRestriction {
            get => _enforceGroupCallingLineIdentityRestriction;
            set {
                EnforceGroupCallingLineIdentityRestrictionSpecified = true;
                _enforceGroupCallingLineIdentityRestriction = value;
            }
        }

        [XmlIgnore]
        public bool EnforceGroupCallingLineIdentityRestrictionSpecified { get; set; }
        
        private bool _enforceEnterpriseCallingLineIdentityRestriction;

        [XmlElement(ElementName = "enforceEnterpriseCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
        public bool EnforceEnterpriseCallingLineIdentityRestriction {
            get => _enforceEnterpriseCallingLineIdentityRestriction;
            set {
                EnforceEnterpriseCallingLineIdentityRestrictionSpecified = true;
                _enforceEnterpriseCallingLineIdentityRestriction = value;
            }
        }

        [XmlIgnore]
        public bool EnforceEnterpriseCallingLineIdentityRestrictionSpecified { get; set; }
        
        private string _conferenceURI;

        [XmlElement(ElementName = "conferenceURI", IsNullable = false, Namespace = "")]
        public string ConferenceURI {
            get => _conferenceURI;
            set {
                ConferenceURISpecified = true;
                _conferenceURI = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceURISpecified { get; set; }
        
        private int _maxConferenceParties;

        [XmlElement(ElementName = "maxConferenceParties", IsNullable = false, Namespace = "")]
        public int MaxConferenceParties {
            get => _maxConferenceParties;
            set {
                MaxConferencePartiesSpecified = true;
                _maxConferenceParties = value;
            }
        }

        [XmlIgnore]
        public bool MaxConferencePartiesSpecified { get; set; }
        
    }
}
