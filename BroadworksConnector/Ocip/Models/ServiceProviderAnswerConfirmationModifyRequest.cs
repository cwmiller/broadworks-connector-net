using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAnswerConfirmationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection AnnouncementMessageSelection { get; set; }
    [XmlElement(ElementName = "confirmationMessageAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource ConfirmationMessageAudioFile { get; set; }
    [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false)]
    public int ConfirmationTimoutSeconds { get; set; }
 }
}
