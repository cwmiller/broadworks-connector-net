using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCallTypeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _callTypeTable;

    [XmlElement(ElementName = "callTypeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CallTypeTable {
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
