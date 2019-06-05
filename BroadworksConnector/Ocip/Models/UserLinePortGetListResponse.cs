using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserLinePortGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _linePortTable;

    [XmlElement(ElementName = "linePortTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable LinePortTable {
        get => _linePortTable;
        set {
            LinePortTableSpecified = true;
            _linePortTable = value;
        }
    }

    [XmlIgnore]
    public bool LinePortTableSpecified { get; set; }
}
}
