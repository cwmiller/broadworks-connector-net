using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderAnswerConfirmationGetRequest.
    /// Replaced By: ServiceProviderAnswerConfirmationGetResponse16
    /// <see cref="ServiceProviderAnswerConfirmationGetRequest"/>
    /// <see cref="ServiceProviderAnswerConfirmationGetResponse16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:17778""}]")]
    public class ServiceProviderAnswerConfirmationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection _announcementMessageSelection;

        [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17778")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17778")]
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

        protected int _confirmationTimoutSeconds;

        [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17778")]
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
