using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistEnterpriseNoteGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "receptionistUserId", IsNullable = false)]
    public string ReceptionistUserId { get; set; }
    [XmlElement(ElementName = "contactUserId", IsNullable = false)]
    public string ContactUserId { get; set; }
    [XmlElement(ElementName = "vonUser", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VirtualOnNetUserKey VonUser { get; set; }
 }
}
