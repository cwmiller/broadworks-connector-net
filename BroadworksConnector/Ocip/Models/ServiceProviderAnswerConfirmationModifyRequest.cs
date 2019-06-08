using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAnswerConfirmationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection _announcementMessageSelection;

    [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection AnnouncementMessageSelection {
        get => _announcementMessageSelection;
        set {
            AnnouncementMessageSelectionSpecified = true;
            _announcementMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _confirmationMessageAudioFile;

    [XmlElement(ElementName = "confirmationMessageAudioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource ConfirmationMessageAudioFile {
        get => _confirmationMessageAudioFile;
        set {
            ConfirmationMessageAudioFileSpecified = true;
            _confirmationMessageAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmationMessageAudioFileSpecified { get; set; }
    private int _confirmationTimoutSeconds;

    [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false, Namespace = "")]
    public int ConfirmationTimoutSeconds {
        get => _confirmationTimoutSeconds;
        set {
            ConfirmationTimoutSecondsSpecified = true;
            _confirmationTimoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmationTimoutSecondsSpecified { get; set; }
}
}
