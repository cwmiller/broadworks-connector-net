using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackGetLineTypeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _lineTypeTable;

    [XmlElement(ElementName = "lineTypeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable LineTypeTable {
        get => _lineTypeTable;
        set {
            LineTypeTableSpecified = true;
            _lineTypeTable = value;
        }
    }

    [XmlIgnore]
    public bool LineTypeTableSpecified { get; set; }
}
}
