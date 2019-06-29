using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies an existing Call Center Agent Threshold Profile in the Group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:2481""}]")]
    public class GroupCallCenterAgentThresholdProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
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
        protected bool GroupIdSpecified { get; set; }

        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
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
        protected bool ProfileNameSpecified { get; set; }

        private string _newProfileName;

        [XmlElement(ElementName = "newProfileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewProfileName
        {
            get => _newProfileName;
            set
            {
                NewProfileNameSpecified = true;
                _newProfileName = value;
            }
        }

        [XmlIgnore]
        protected bool NewProfileNameSpecified { get; set; }

        private string _profileDescription;

        [XmlElement(ElementName = "profileDescription", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
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
        protected bool ProfileDescriptionSpecified { get; set; }

        private int? _thresholdCurrentCallStateIdleTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentCallStateIdleTimeYellow
        {
            get => _thresholdCurrentCallStateIdleTimeYellow;
            set
            {
                ThresholdCurrentCallStateIdleTimeYellowSpecified = true;
                _thresholdCurrentCallStateIdleTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentCallStateIdleTimeYellowSpecified { get; set; }

        private int? _thresholdCurrentCallStateIdleTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentCallStateIdleTimeRed
        {
            get => _thresholdCurrentCallStateIdleTimeRed;
            set
            {
                ThresholdCurrentCallStateIdleTimeRedSpecified = true;
                _thresholdCurrentCallStateIdleTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentCallStateIdleTimeRedSpecified { get; set; }

        private int? _thresholdCurrentCallStateOnCallTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentCallStateOnCallTimeYellow
        {
            get => _thresholdCurrentCallStateOnCallTimeYellow;
            set
            {
                ThresholdCurrentCallStateOnCallTimeYellowSpecified = true;
                _thresholdCurrentCallStateOnCallTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentCallStateOnCallTimeYellowSpecified { get; set; }

        private int? _thresholdCurrentCallStateOnCallTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentCallStateOnCallTimeRed
        {
            get => _thresholdCurrentCallStateOnCallTimeRed;
            set
            {
                ThresholdCurrentCallStateOnCallTimeRedSpecified = true;
                _thresholdCurrentCallStateOnCallTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentCallStateOnCallTimeRedSpecified { get; set; }

        private int? _thresholdCurrentAgentStateUnavailableTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentAgentStateUnavailableTimeYellow
        {
            get => _thresholdCurrentAgentStateUnavailableTimeYellow;
            set
            {
                ThresholdCurrentAgentStateUnavailableTimeYellowSpecified = true;
                _thresholdCurrentAgentStateUnavailableTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentAgentStateUnavailableTimeYellowSpecified { get; set; }

        private int? _thresholdCurrentAgentStateUnavailableTimeRed;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdCurrentAgentStateUnavailableTimeRed
        {
            get => _thresholdCurrentAgentStateUnavailableTimeRed;
            set
            {
                ThresholdCurrentAgentStateUnavailableTimeRedSpecified = true;
                _thresholdCurrentAgentStateUnavailableTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCurrentAgentStateUnavailableTimeRedSpecified { get; set; }

        private int? _thresholdAverageBusyInTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageBusyInTimeYellow
        {
            get => _thresholdAverageBusyInTimeYellow;
            set
            {
                ThresholdAverageBusyInTimeYellowSpecified = true;
                _thresholdAverageBusyInTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageBusyInTimeYellowSpecified { get; set; }

        private int? _thresholdAverageBusyInTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageBusyInTimeRed
        {
            get => _thresholdAverageBusyInTimeRed;
            set
            {
                ThresholdAverageBusyInTimeRedSpecified = true;
                _thresholdAverageBusyInTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageBusyInTimeRedSpecified { get; set; }

        private int? _thresholdAverageBusyOutTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageBusyOutTimeYellow
        {
            get => _thresholdAverageBusyOutTimeYellow;
            set
            {
                ThresholdAverageBusyOutTimeYellowSpecified = true;
                _thresholdAverageBusyOutTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageBusyOutTimeYellowSpecified { get; set; }

        private int? _thresholdAverageBusyOutTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageBusyOutTimeRed
        {
            get => _thresholdAverageBusyOutTimeRed;
            set
            {
                ThresholdAverageBusyOutTimeRedSpecified = true;
                _thresholdAverageBusyOutTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageBusyOutTimeRedSpecified { get; set; }

        private int? _thresholdAverageWrapUpTimeYellow;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageWrapUpTimeYellow
        {
            get => _thresholdAverageWrapUpTimeYellow;
            set
            {
                ThresholdAverageWrapUpTimeYellowSpecified = true;
                _thresholdAverageWrapUpTimeYellow = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageWrapUpTimeYellowSpecified { get; set; }

        private int? _thresholdAverageWrapUpTimeRed;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int? ThresholdAverageWrapUpTimeRed
        {
            get => _thresholdAverageWrapUpTimeRed;
            set
            {
                ThresholdAverageWrapUpTimeRedSpecified = true;
                _thresholdAverageWrapUpTimeRed = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdAverageWrapUpTimeRedSpecified { get; set; }

        private bool _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
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
        protected bool EnableNotificationEmailSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAgentThresholdProfileReplacementNotificationEmailList _notificationEmailAddressList;

        [XmlElement(ElementName = "notificationEmailAddressList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        public BroadWorksConnector.Ocip.Models.CallCenterAgentThresholdProfileReplacementNotificationEmailList NotificationEmailAddressList
        {
            get => _notificationEmailAddressList;
            set
            {
                NotificationEmailAddressListSpecified = true;
                _notificationEmailAddressList = value;
            }
        }

        [XmlIgnore]
        protected bool NotificationEmailAddressListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2481")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList
        {
            get => _agentUserIdList;
            set
            {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserIdListSpecified { get; set; }

    }
}
