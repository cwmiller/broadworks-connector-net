using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPhoneDirectoryGetListResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "directoryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DirectoryTable { get; set; }
 }
}
