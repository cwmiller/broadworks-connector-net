using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVideoServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _videoServerTable;

    [XmlElement(ElementName = "videoServerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable VideoServerTable {
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
