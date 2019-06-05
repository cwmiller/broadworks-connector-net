using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveGetFilteringResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableFiltering;

    [XmlElement(ElementName = "enableFiltering", IsNullable = false, Namespace = "")]
    public bool EnableFiltering {
        get => _enableFiltering;
        set {
            EnableFilteringSpecified = true;
            _enableFiltering = value;
        }
    }

    [XmlIgnore]
    public bool EnableFilteringSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExecutiveCallFilteringMode _filteringMode;

    [XmlElement(ElementName = "filteringMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringMode FilteringMode {
        get => _filteringMode;
        set {
            FilteringModeSpecified = true;
            _filteringMode = value;
        }
    }

    [XmlIgnore]
    public bool FilteringModeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType _simpleFilterType;

    [XmlElement(ElementName = "simpleFilterType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType SimpleFilterType {
        get => _simpleFilterType;
        set {
            SimpleFilterTypeSpecified = true;
            _simpleFilterType = value;
        }
    }

    [XmlIgnore]
    public bool SimpleFilterTypeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _criteriaTable;

    [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable {
        get => _criteriaTable;
        set {
            CriteriaTableSpecified = true;
            _criteriaTable = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaTableSpecified { get; set; }
}
}
