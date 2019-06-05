using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingInhibitedAttributeValuePairCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _inhibitedAttributeValuePairCodeTable;

    [XmlElement(ElementName = "inhibitedAttributeValuePairCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable InhibitedAttributeValuePairCodeTable {
        get => _inhibitedAttributeValuePairCodeTable;
        set {
            InhibitedAttributeValuePairCodeTableSpecified = true;
            _inhibitedAttributeValuePairCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool InhibitedAttributeValuePairCodeTableSpecified { get; set; }
}
}
