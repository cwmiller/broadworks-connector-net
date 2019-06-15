using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterAgentThresholdDefaultProfileGetRequest.
    /// The agent table contains the agents assigned to the profile and
    /// has column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address";
        /// <see cref="GroupCallCenterAgentThresholdDefaultProfileGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterAgentThresholdDefaultProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        public string ProfileName {
            get => _profileName;
            set {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }
        
        private string _profileDescription;

        [XmlElement(ElementName = "profileDescription", IsNullable = false, Namespace = "")]
        public string ProfileDescription {
            get => _profileDescription;
            set {
                ProfileDescriptionSpecified = true;
                _profileDescription = value;
            }
        }

        [XmlIgnore]
        public bool ProfileDescriptionSpecified { get; set; }
        
        private int _thresholdCurrentCallStateIdleTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentCallStateIdleTimeYellow {
            get => _thresholdCurrentCallStateIdleTimeYellow;
            set {
                ThresholdCurrentCallStateIdleTimeYellowSpecified = true;
                _thresholdCurrentCallStateIdleTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateIdleTimeYellowSpecified { get; set; }
        
        private int _thresholdCurrentCallStateIdleTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentCallStateIdleTimeRed {
            get => _thresholdCurrentCallStateIdleTimeRed;
            set {
                ThresholdCurrentCallStateIdleTimeRedSpecified = true;
                _thresholdCurrentCallStateIdleTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateIdleTimeRedSpecified { get; set; }
        
        private int _thresholdCurrentCallStateOnCallTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentCallStateOnCallTimeYellow {
            get => _thresholdCurrentCallStateOnCallTimeYellow;
            set {
                ThresholdCurrentCallStateOnCallTimeYellowSpecified = true;
                _thresholdCurrentCallStateOnCallTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateOnCallTimeYellowSpecified { get; set; }
        
        private int _thresholdCurrentCallStateOnCallTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentCallStateOnCallTimeRed {
            get => _thresholdCurrentCallStateOnCallTimeRed;
            set {
                ThresholdCurrentCallStateOnCallTimeRedSpecified = true;
                _thresholdCurrentCallStateOnCallTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateOnCallTimeRedSpecified { get; set; }
        
        private int _thresholdCurrentAgentStateUnavailableTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentAgentStateUnavailableTimeYellow {
            get => _thresholdCurrentAgentStateUnavailableTimeYellow;
            set {
                ThresholdCurrentAgentStateUnavailableTimeYellowSpecified = true;
                _thresholdCurrentAgentStateUnavailableTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentAgentStateUnavailableTimeYellowSpecified { get; set; }
        
        private int _thresholdCurrentAgentStateUnavailableTimeRed;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdCurrentAgentStateUnavailableTimeRed {
            get => _thresholdCurrentAgentStateUnavailableTimeRed;
            set {
                ThresholdCurrentAgentStateUnavailableTimeRedSpecified = true;
                _thresholdCurrentAgentStateUnavailableTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentAgentStateUnavailableTimeRedSpecified { get; set; }
        
        private int _thresholdAverageBusyInTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdAverageBusyInTimeYellow {
            get => _thresholdAverageBusyInTimeYellow;
            set {
                ThresholdAverageBusyInTimeYellowSpecified = true;
                _thresholdAverageBusyInTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyInTimeYellowSpecified { get; set; }
        
        private int _thresholdAverageBusyInTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdAverageBusyInTimeRed {
            get => _thresholdAverageBusyInTimeRed;
            set {
                ThresholdAverageBusyInTimeRedSpecified = true;
                _thresholdAverageBusyInTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyInTimeRedSpecified { get; set; }
        
        private int _thresholdAverageBusyOutTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdAverageBusyOutTimeYellow {
            get => _thresholdAverageBusyOutTimeYellow;
            set {
                ThresholdAverageBusyOutTimeYellowSpecified = true;
                _thresholdAverageBusyOutTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyOutTimeYellowSpecified { get; set; }
        
        private int _thresholdAverageBusyOutTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdAverageBusyOutTimeRed {
            get => _thresholdAverageBusyOutTimeRed;
            set {
                ThresholdAverageBusyOutTimeRedSpecified = true;
                _thresholdAverageBusyOutTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyOutTimeRedSpecified { get; set; }
        
        private int _thresholdAverageWrapUpTimeYellow;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = false, Namespace = "")]
        public int ThresholdAverageWrapUpTimeYellow {
            get => _thresholdAverageWrapUpTimeYellow;
            set {
                ThresholdAverageWrapUpTimeYellowSpecified = true;
                _thresholdAverageWrapUpTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageWrapUpTimeYellowSpecified { get; set; }
        
        private int _thresholdAverageWrapUpTimeRed;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = false, Namespace = "")]
        public int ThresholdAverageWrapUpTimeRed {
            get => _thresholdAverageWrapUpTimeRed;
            set {
                ThresholdAverageWrapUpTimeRedSpecified = true;
                _thresholdAverageWrapUpTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageWrapUpTimeRedSpecified { get; set; }
        
        private bool _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        public bool EnableNotificationEmail {
            get => _enableNotificationEmail;
            set {
                EnableNotificationEmailSpecified = true;
                _enableNotificationEmail = value;
            }
        }

        [XmlIgnore]
        public bool EnableNotificationEmailSpecified { get; set; }
        
        private List<string> _notificationEmailAddress;

        [XmlElement(ElementName = "notificationEmailAddress", IsNullable = false, Namespace = "")]
        public List<string> NotificationEmailAddress {
            get => _notificationEmailAddress;
            set {
                NotificationEmailAddressSpecified = true;
                _notificationEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool NotificationEmailAddressSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _agentTable;

        [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentTable {
            get => _agentTable;
            set {
                AgentTableSpecified = true;
                _agentTable = value;
            }
        }

        [XmlIgnore]
        public bool AgentTableSpecified { get; set; }
        
    }
}
