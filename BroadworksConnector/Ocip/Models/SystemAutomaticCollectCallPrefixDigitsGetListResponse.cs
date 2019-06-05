using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallPrefixDigitsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _prefixTable;

    [XmlElement(ElementName = "prefixTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PrefixTable {
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
