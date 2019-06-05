using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _mediaServerTable;

    [XmlElement(ElementName = "mediaServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable MediaServerTable {
        get => _mediaServerTable;
        set {
            MediaServerTableSpecified = true;
            _mediaServerTable = value;
        }
    }

    [XmlIgnore]
    public bool MediaServerTableSpecified { get; set; }
}
}
