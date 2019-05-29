using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAnswerConfirmationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection AnnouncementMessageSelection { get; set; }
    [XmlElement(ElementName = "confirmationMessageAudioFileDescription", IsNullable = false)]
    public string ConfirmationMessageAudioFileDescription { get; set; }
    [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false)]
    public int ConfirmationTimoutSeconds { get; set; }
 }
}
