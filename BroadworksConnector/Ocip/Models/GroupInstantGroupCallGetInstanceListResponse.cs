using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _instantGroupCallTable;

    [XmlElement(ElementName = "instantGroupCallTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable InstantGroupCallTable {
        get => _instantGroupCallTable;
        set {
            InstantGroupCallTableSpecified = true;
            _instantGroupCallTable = value;
        }
    }

    [XmlIgnore]
    public bool InstantGroupCallTableSpecified { get; set; }
}
}
