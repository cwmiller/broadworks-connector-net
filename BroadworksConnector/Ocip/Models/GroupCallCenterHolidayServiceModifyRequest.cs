using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's holiday service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:12957""}]")]
    public class GroupCallCenterHolidayServiceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }

        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        [MinLength(1)]
        [MaxLength(161)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferPhoneNumberSpecified { get; set; }

        private bool _playAnnouncementBeforeAction;

        [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        public bool PlayAnnouncementBeforeAction
        {
            get => _playAnnouncementBeforeAction;
            set
            {
                PlayAnnouncementBeforeActionSpecified = true;
                _playAnnouncementBeforeAction = value;
            }
        }

        [XmlIgnore]
        public bool PlayAnnouncementBeforeActionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:12957")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileSpecified { get; set; }

    }
}
