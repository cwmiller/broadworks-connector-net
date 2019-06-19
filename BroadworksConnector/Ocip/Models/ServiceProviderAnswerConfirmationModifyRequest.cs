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
    /// Replaced By: ServiceProviderAnswerConfirmationModifyRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderAnswerConfirmationModifyRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9569""}]")]
    public class ServiceProviderAnswerConfirmationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9569")]
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

        private BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection _announcementMessageSelection;

        [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9569")]
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
        public bool AnnouncementMessageSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _confirmationMessageAudioFile;

        [XmlElement(ElementName = "confirmationMessageAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9569")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource ConfirmationMessageAudioFile
        {
            get => _confirmationMessageAudioFile;
            set
            {
                ConfirmationMessageAudioFileSpecified = true;
                _confirmationMessageAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmationMessageAudioFileSpecified { get; set; }

        private int _confirmationTimoutSeconds;

        [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9569")]
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
        public bool ConfirmationTimoutSecondsSpecified { get; set; }

    }
}
