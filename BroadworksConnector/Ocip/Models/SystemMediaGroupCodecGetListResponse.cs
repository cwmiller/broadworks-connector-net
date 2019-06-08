using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaGroupCodecGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _codecTable;

    [XmlElement(ElementName = "codecTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CodecTable {
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