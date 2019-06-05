using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _mediaTable;

    [XmlElement(ElementName = "mediaTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable MediaTable {
        get => _mediaTable;
        set {
            MediaTableSpecified = true;
            _mediaTable = value;
        }
    }

    [XmlIgnore]
    public bool MediaTableSpecified { get; set; }
}
}
