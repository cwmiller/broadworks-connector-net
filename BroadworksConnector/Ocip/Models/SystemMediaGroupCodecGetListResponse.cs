using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaGroupCodecGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _codecTable;

    [XmlElement(ElementName = "codecTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CodecTable {
        get => _codecTable;
        set {
            CodecTableSpecified = true;
            _codecTable = value;
        }
    }

    [XmlIgnore]
    public bool CodecTableSpecified { get; set; }
}
}
