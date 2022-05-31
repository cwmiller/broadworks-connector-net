using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderAnswerConfirmationGetRequest16.
    /// <see cref="ServiceProviderAnswerConfirmationGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1681""}]")]
    public class ServiceProviderAnswerConfirmationGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection _announcementMessageSelection;

        [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1681")]
        public BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection AnnouncementMessageSelection
        {
            get => _announcementMessageSelection;
            set
            {
                AnnouncementMessageSelectionSpecified = true;
                _announcementMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementMessageSelectionSpecified { get; set; }

        protected string _confirmationMessageAudioFileDescription;

        [XmlElement(ElementName = "confirmationMessageAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1681")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfirmationMessageAudioFileDescription
        {
            get => _confirmationMessageAudioFileDescription;
            set
            {
                ConfirmationMessageAudioFileDescriptionSpecified = true;
                _confirmationMessageAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmationMessageAudioFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _confirmationMessageMediaType;

        [XmlElement(ElementName = "confirmationMessageMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1681")]
        public BroadWorksConnector.Ocip.Models.MediaFileType ConfirmationMessageMediaType
        {
            get => _confirmationMessageMediaType;
            set
            {
                ConfirmationMessageMediaTypeSpecified = true;
                _confirmationMessageMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmationMessageMediaTypeSpecified { get; set; }

        protected int _confirmationTimoutSeconds;

        [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1681")]
        [MinInclusive(2)]
        [MaxInclusive(30)]
        public int ConfirmationTimoutSeconds
        {
            get => _confirmationTimoutSeconds;
            set
            {
                ConfirmationTimoutSecondsSpecified = true;
                _confirmationTimoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmationTimoutSecondsSpecified { get; set; }

    }
}
