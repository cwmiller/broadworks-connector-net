using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackGetLineTypeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "lineTypeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable LineTypeTable { get; set; }
 }
}
