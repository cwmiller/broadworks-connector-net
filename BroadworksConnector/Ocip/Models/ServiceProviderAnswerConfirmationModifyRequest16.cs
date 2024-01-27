using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a service provider or enterprise's answer confirmation settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1780""}]")]
    public class ServiceProviderAnswerConfirmationModifyRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1780")]
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

        protected BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection _announcementMessageSelection;

        [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1780")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _confirmationMessageAudioFile;

        [XmlElement(ElementName = "confirmationMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1780")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource ConfirmationMessageAudioFile
        {
            get => _confirmationMessageAudioFile;
            set
            {
                ConfirmationMessageAudioFileSpecified = true;
                _confirmationMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmationMessageAudioFileSpecified { get; set; }

        protected int _confirmationTimoutSeconds;

        [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1780")]
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
