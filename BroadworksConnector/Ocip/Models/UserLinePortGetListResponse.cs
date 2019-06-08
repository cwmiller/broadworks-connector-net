using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserLinePortGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _linePortTable;

    [XmlElement(ElementName = "linePortTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable LinePortTable {
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
