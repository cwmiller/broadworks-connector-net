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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:2485""}]")]
    public class GroupCallCenterAgentThresholdProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected string _newProfileName;

        [XmlElement(ElementName = "newProfileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewProfileName
        {
            get => _newProfileName;
            set
            {
                NewProfileNameSpecified = (value != null);
                _newProfileName = value;
            }
        }

        [XmlIgnore]
        protected bool NewProfileNameSpecified { get; set; }

        protected string _profileDescription;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "profileDescription", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdCurrentCallStateIdleTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdCurrentCallStateIdleTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentCallStateIdleTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdCurrentCallStateOnCallTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdCurrentCallStateOnCallTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentCallStateOnCallTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdCurrentAgentStateUnavailableTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdCurrentAgentStateUnavailableTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdCurrentAgentStateUnavailableTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdAverageBusyInTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageBusyInTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdAverageBusyInTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageBusyInTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdAverageBusyOutTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageBusyOutTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdAverageBusyOutTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageBusyOutTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdAverageWrapUpTimeYellow;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageWrapUpTimeYellow", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected int? _thresholdAverageWrapUpTimeRed;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "thresholdAverageWrapUpTimeRed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected bool? _enableNotificationEmail;

        [XmlElement(ElementName = "enableNotificationEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
        public bool? EnableNotificationEmail
        {
            get => _enableNotificationEmail;
            set
            {
                EnableNotificationEmailSpecified = (value != null);
                _enableNotificationEmail = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNotificationEmailSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAgentThresholdProfileReplacementNotificationEmailList _notificationEmailAddressList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "notificationEmailAddressList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2485")]
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
