using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistEnterpriseNoteModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "receptionistUserId", IsNullable = false)]
    public string ReceptionistUserId { get; set; }
    [XmlElement(ElementName = "receptionistUserAndNote", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ReceptionistContactUserAndNote> ReceptionistUserAndNote { get; set; }
 }
}
