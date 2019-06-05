using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantExclusionNumberGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _exclusionNumberTable;

    [XmlElement(ElementName = "exclusionNumberTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ExclusionNumberTable {
        get => _exclusionNumberTable;
        set {
            ExclusionNumberTableSpecified = true;
            _exclusionNumberTable = value;
        }
    }

    [XmlIgnore]
    public bool ExclusionNumberTableSpecified { get; set; }
}
}
