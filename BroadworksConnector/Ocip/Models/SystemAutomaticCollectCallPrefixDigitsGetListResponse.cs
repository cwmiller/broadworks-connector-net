using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallPrefixDigitsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _prefixTable;

    [XmlElement(ElementName = "prefixTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable PrefixTable {
        get => _prefixTable;
        set {
            PrefixTableSpecified = true;
            _prefixTable = value;
        }
    }

    [XmlIgnore]
    public bool PrefixTableSpecified { get; set; }
}
}
