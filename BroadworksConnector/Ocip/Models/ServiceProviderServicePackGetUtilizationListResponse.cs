using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackGetUtilizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _servicePackName;

    [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
    public List<string> ServicePackName {
        get => _servicePackName;
        set {
            ServicePackNameSpecified = true;
            _servicePackName = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.C.OCITable> _serviceUtilizationTable;

    [XmlElement(ElementName = "serviceUtilizationTable", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.C.OCITable> ServiceUtilizationTable {
        get => _serviceUtilizationTable;
        set {
            ServiceUtilizationTableSpecified = true;
            _serviceUtilizationTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUtilizationTableSpecified { get; set; }
}
}
