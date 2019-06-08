using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingInhibitedAttributeValuePairCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _inhibitedAttributeValuePairCodeTable;

    [XmlElement(ElementName = "inhibitedAttributeValuePairCodeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable InhibitedAttributeValuePairCodeTable {
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
