using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterAgentThresholdProfileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
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
        private string _newProfileName;

        [XmlElement(ElementName = "newProfileName", IsNullable = false, Namespace = "")]
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
        public bool NewProfileNameSpecified { get; set; }
        private string _profileDescription;

        [XmlElement(ElementName = "profileDescription", IsNullable = true, Namespace = "")]
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
        private int? _thresholdCurrentCallStateIdleTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = true, Namespace = "")]
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
        public bool ThresholdCurrentCallStateIdleTimeYellowSpecified { get; set; }
        private int? _thresholdCurrentCallStateIdleTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = true, Namespace = "")]
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
        public bool ThresholdCurrentCallStateIdleTimeRedSpecified { get; set; }
        private int? _thresholdCurrentCallStateOnCallTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = true, Namespace = "")]
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
        public bool ThresholdCurrentCallStateOnCallTimeYellowSpecified { get; set; }
        private int? _thresholdCurrentCallStateOnCallTimeRed;

        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = true, Namespace = "")]
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
        public bool ThresholdCurrentCallStateOnCallTimeRedSpecified { get; set; }
        private int? _thresholdCurrentAgentStateUnavailableTimeYellow;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = true, Namespace = "")]
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
        public bool ThresholdCurrentAgentStateUnavailableTimeYellowSpecified { get; set; }
        private int? _thresholdCurrentAgentStateUnavailableTimeRed;

        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = true, Namespace = "")]
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
        public bool ThresholdCurrentAgentStateUnavailableTimeRedSpecified { get; set; }
        private int? _thresholdAverageBusyInTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = true, Namespace = "")]
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
        public bool ThresholdAverageBusyInTimeYellowSpecified { get; set; }
        private int? _thresholdAverageBusyInTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = true, Namespace = "")]
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
        public bool ThresholdAverageBusyInTimeRedSpecified { get; set; }
        private int? _thresholdAverageBusyOutTimeYellow;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = true, Namespace = "")]
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
        public bool ThresholdAverageBusyOutTimeYellowSpecified { get; set; }
        private int? _thresholdAverageBusyOutTimeRed;

        [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = true, Namespace = "")]
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
        public bool ThresholdAverageBusyOutTimeRedSpecified { get; set; }
        private int? _thresholdAverageWrapUpTimeYellow;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = true, Namespace = "")]
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
        public bool ThresholdAverageWrapUpTimeYellowSpecified { get; set; }
        private int? _thresholdAverageWrapUpTimeRed;

        [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = true, Namespace = "")]
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
        public bool ThresholdAverageWrapUpTimeRedSpecified { get; set; }
        private bool _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.CallCenterAgentThresholdProfileReplacementNotificationEmailList _notificationEmailAddressList;

        [XmlElement(ElementName = "notificationEmailAddressList", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAgentThresholdProfileReplacementNotificationEmailList NotificationEmailAddressList
        {
            get => _notificationEmailAddressList;
            set
            {
                NotificationEmailAddressListSpecified = true;
                _notificationEmailAddressList = value;
            }
        }

        [XmlIgnore]
        public bool NotificationEmailAddressListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList
        {
            get => _agentUserIdList;
            set
            {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdListSpecified { get; set; }
    }
}
