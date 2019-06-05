using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDialableCallerIDGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useGroupCriteria;

    [XmlElement(ElementName = "useGroupCriteria", IsNullable = false, Namespace = "")]
    public bool UseGroupCriteria {
        get => _useGroupCriteria;
        set {
            UseGroupCriteriaSpecified = true;
            _useGroupCriteria = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupCriteriaSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.NsScreeningFailurePolicy _nsScreeningFailurePolicy;

    [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy {
        get => _nsScreeningFailurePolicy;
        set {
            NsScreeningFailurePolicySpecified = true;
            _nsScreeningFailurePolicy = value;
        }
    }

    [XmlIgnore]
    public bool NsScreeningFailurePolicySpecified { get; set; }
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
