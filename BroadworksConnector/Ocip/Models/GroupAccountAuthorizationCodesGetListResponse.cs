using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccountAuthorizationCodesGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "codeEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AccountAuthorizationCodeEntry> CodeEntry { get; set; }
 }
}
