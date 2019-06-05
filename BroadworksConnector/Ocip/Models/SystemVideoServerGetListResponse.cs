using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVideoServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _videoServerTable;

    [XmlElement(ElementName = "videoServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable VideoServerTable {
        get => _videoServerTable;
        set {
            VideoServerTableSpecified = true;
            _videoServerTable = value;
        }
    }

    [XmlIgnore]
    public bool VideoServerTableSpecified { get; set; }
}
}
