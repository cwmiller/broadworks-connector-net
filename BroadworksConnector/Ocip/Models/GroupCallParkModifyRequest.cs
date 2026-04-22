using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Group's Call Park settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b6fd73d148b9b309dce1d2f04516ddfa:519""}]")]
    public class GroupCallParkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
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
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
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

        protected int? _recallTimerSeconds;

        [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int? RecallTimerSeconds
        {
            get => _recallTimerSeconds;
            set
            {
                RecallTimerSecondsSpecified = (value != null);
                _recallTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RecallTimerSecondsSpecified { get; set; }

        protected int? _displayTimerSeconds;

        [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        [MinInclusive(2)]
        [MaxInclusive(15)]
        public int? DisplayTimerSeconds
        {
            get => _displayTimerSeconds;
            set
            {
                DisplayTimerSecondsSpecified = (value != null);
                _displayTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool DisplayTimerSecondsSpecified { get; set; }

        protected bool? _enableDestinationAnnouncement;

        [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        public bool? EnableDestinationAnnouncement
        {
            get => _enableDestinationAnnouncement;
            set
            {
                EnableDestinationAnnouncementSpecified = (value != null);
                _enableDestinationAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDestinationAnnouncementSpecified { get; set; }

        protected string _recallAlternateUserId;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "recallAlternateUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RecallAlternateUserId
        {
            get => _recallAlternateUserId;
            set
            {
                RecallAlternateUserIdSpecified = true;
                _recallAlternateUserId = value;
            }
        }

        [XmlIgnore]
        protected bool RecallAlternateUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RingPattern? _recallRingPattern;

        [XmlElement(ElementName = "recallRingPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        public BroadWorksConnector.Ocip.Models.RingPattern? RecallRingPattern
        {
            get => _recallRingPattern;
            set
            {
                RecallRingPatternSpecified = (value != null);
                _recallRingPattern = value;
            }
        }

        [XmlIgnore]
        protected bool RecallRingPatternSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallParkRecallTo? _recallTo;

        [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        public BroadWorksConnector.Ocip.Models.CallParkRecallTo? RecallTo
        {
            get => _recallTo;
            set
            {
                RecallToSpecified = (value != null);
                _recallTo = value;
            }
        }

        [XmlIgnore]
        protected bool RecallToSpecified { get; set; }

        protected int? _alternateUserRecallTimerSeconds;

        [XmlElement(ElementName = "alternateUserRecallTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b6fd73d148b9b309dce1d2f04516ddfa:519")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int? AlternateUserRecallTimerSeconds
        {
            get => _alternateUserRecallTimerSeconds;
            set
            {
                AlternateUserRecallTimerSecondsSpecified = (value != null);
                _alternateUserRecallTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateUserRecallTimerSecondsSpecified { get; set; }

    }
}
