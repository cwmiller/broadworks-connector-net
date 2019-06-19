using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a new Call Center Agent Threshold Profile in a Group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:2140""}]")]
    public class GroupCallCenterAgentThresholdProfileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ProfileName
        {
            get => _profileName;
            set
            {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }

        private string _profileDescription;

        [XmlElement(ElementName = "profileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ProfileDescription
        {
            get => _profileDescription;
            set
            {
                ProfileDescriptionSpecified = true;
                _profileDescription = value;
            }
        }

        [XmlIgnore]
        public bool ProfileDescriptionSpecified { get; set; }

        private int _thresholdCurrentCallStateIdleTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentCallStateIdleTimeYellow
        {
            get => _thresholdCurrentCallStateIdleTimeYellow;
            set
            {
                ThresholdCurrentCallStateIdleTimeYellowSpecified = true;
                _thresholdCurrentCallStateIdleTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateIdleTimeYellowSpecified { get; set; }

        private int _thresholdCurrentCallStateIdleTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentCallStateIdleTimeRed
        {
            get => _thresholdCurrentCallStateIdleTimeRed;
            set
            {
                ThresholdCurrentCallStateIdleTimeRedSpecified = true;
                _thresholdCurrentCallStateIdleTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateIdleTimeRedSpecified { get; set; }

        private int _thresholdCurrentCallStateOnCallTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentCallStateOnCallTimeYellow
        {
            get => _thresholdCurrentCallStateOnCallTimeYellow;
            set
            {
                ThresholdCurrentCallStateOnCallTimeYellowSpecified = true;
                _thresholdCurrentCallStateOnCallTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateOnCallTimeYellowSpecified { get; set; }

        private int _thresholdCurrentCallStateOnCallTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentCallStateOnCallTimeRed
        {
            get => _thresholdCurrentCallStateOnCallTimeRed;
            set
            {
                ThresholdCurrentCallStateOnCallTimeRedSpecified = true;
                _thresholdCurrentCallStateOnCallTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentCallStateOnCallTimeRedSpecified { get; set; }

        private int _thresholdCurrentAgentStateUnavailableTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentAgentStateUnavailableTimeYellow
        {
            get => _thresholdCurrentAgentStateUnavailableTimeYellow;
            set
            {
                ThresholdCurrentAgentStateUnavailableTimeYellowSpecified = true;
                _thresholdCurrentAgentStateUnavailableTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentAgentStateUnavailableTimeYellowSpecified { get; set; }

        private int _thresholdCurrentAgentStateUnavailableTimeRed;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdCurrentAgentStateUnavailableTimeRed
        {
            get => _thresholdCurrentAgentStateUnavailableTimeRed;
            set
            {
                ThresholdCurrentAgentStateUnavailableTimeRedSpecified = true;
                _thresholdCurrentAgentStateUnavailableTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdCurrentAgentStateUnavailableTimeRedSpecified { get; set; }

        private int _thresholdAverageBusyInTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageBusyInTimeYellow
        {
            get => _thresholdAverageBusyInTimeYellow;
            set
            {
                ThresholdAverageBusyInTimeYellowSpecified = true;
                _thresholdAverageBusyInTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyInTimeYellowSpecified { get; set; }

        private int _thresholdAverageBusyInTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageBusyInTimeRed
        {
            get => _thresholdAverageBusyInTimeRed;
            set
            {
                ThresholdAverageBusyInTimeRedSpecified = true;
                _thresholdAverageBusyInTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyInTimeRedSpecified { get; set; }

        private int _thresholdAverageBusyOutTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageBusyOutTimeYellow
        {
            get => _thresholdAverageBusyOutTimeYellow;
            set
            {
                ThresholdAverageBusyOutTimeYellowSpecified = true;
                _thresholdAverageBusyOutTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyOutTimeYellowSpecified { get; set; }

        private int _thresholdAverageBusyOutTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageBusyOutTimeRed
        {
            get => _thresholdAverageBusyOutTimeRed;
            set
            {
                ThresholdAverageBusyOutTimeRedSpecified = true;
                _thresholdAverageBusyOutTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageBusyOutTimeRedSpecified { get; set; }

        private int _thresholdAverageWrapUpTimeYellow;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageWrapUpTimeYellow
        {
            get => _thresholdAverageWrapUpTimeYellow;
            set
            {
                ThresholdAverageWrapUpTimeYellowSpecified = true;
                _thresholdAverageWrapUpTimeYellow = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageWrapUpTimeYellowSpecified { get; set; }

        private int _thresholdAverageWrapUpTimeRed;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ThresholdAverageWrapUpTimeRed
        {
            get => _thresholdAverageWrapUpTimeRed;
            set
            {
                ThresholdAverageWrapUpTimeRedSpecified = true;
                _thresholdAverageWrapUpTimeRed = value;
            }
        }

        [XmlIgnore]
        public bool ThresholdAverageWrapUpTimeRedSpecified { get; set; }

        private bool _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        public bool EnableNotificationEmail
        {
            get => _enableNotificationEmail;
            set
            {
                EnableNotificationEmailSpecified = true;
                _enableNotificationEmail = value;
            }
        }

        [XmlIgnore]
        public bool EnableNotificationEmailSpecified { get; set; }

        private List<string> _notificationEmailAddress = new List<string>();

        [XmlElement(ElementName = "notificationEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> NotificationEmailAddress
        {
            get => _notificationEmailAddress;
            set
            {
                NotificationEmailAddressSpecified = true;
                _notificationEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool NotificationEmailAddressSpecified { get; set; }

        private List<string> _agentUserId = new List<string>();

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2140")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> AgentUserId
        {
            get => _agentUserId;
            set
            {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }

    }
}
