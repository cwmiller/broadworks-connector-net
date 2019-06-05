using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallTypeGetMappingListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _callTypeMapping;

    [XmlElement(ElementName = "callTypeMapping", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CallTypeMapping {
        get => _callTypeMapping;
        set {
            CallTypeMappingSpecified = true;
            _callTypeMapping = value;
        }
    }

    [XmlIgnore]
    public bool CallTypeMappingSpecified { get; set; }
}
}
