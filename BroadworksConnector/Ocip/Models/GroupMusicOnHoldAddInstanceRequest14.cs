using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Music On Hold Instance to a department.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By: GroupMusicOnHoldAddInstanceRequest14Sp4
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupMusicOnHoldAddInstanceRequest14Sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:11159""}]")]
    public class GroupMusicOnHoldAddInstanceRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
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

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey Department
        {
            get => _department;
            set
            {
                DepartmentSpecified = true;
                _department = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentSpecified { get; set; }

        private bool _isActiveDuringCallHold;

        [XmlElement(ElementName = "isActiveDuringCallHold", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public bool IsActiveDuringCallHold
        {
            get => _isActiveDuringCallHold;
            set
            {
                IsActiveDuringCallHoldSpecified = true;
                _isActiveDuringCallHold = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveDuringCallHoldSpecified { get; set; }

        private bool _isActiveDuringCallPark;

        [XmlElement(ElementName = "isActiveDuringCallPark", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public bool IsActiveDuringCallPark
        {
            get => _isActiveDuringCallPark;
            set
            {
                IsActiveDuringCallParkSpecified = true;
                _isActiveDuringCallPark = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveDuringCallParkSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSelection;

        [XmlElement(ElementName = "messageSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSelection
        {
            get => _messageSelection;
            set
            {
                MessageSelectionSpecified = true;
                _messageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool MessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointAdd _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointAdd AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11159")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileSpecified { get; set; }

    }
}
