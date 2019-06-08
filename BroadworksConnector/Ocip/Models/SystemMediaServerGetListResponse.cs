using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _mediaServerTable;

    [XmlElement(ElementName = "mediaServerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MediaServerTable {
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
