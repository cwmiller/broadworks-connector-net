using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _callTypeTable;

    [XmlElement(ElementName = "callTypeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CallTypeTable {
        get => _callTypeTable;
        set {
            CallTypeTableSpecified = true;
            _callTypeTable = value;
        }
    }

    [XmlIgnore]
    public bool CallTypeTableSpecified { get; set; }
}
}
