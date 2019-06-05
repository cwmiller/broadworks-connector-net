using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallNotifyGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _callNotifyEmailAddress;

    [XmlElement(ElementName = "callNotifyEmailAddress", IsNullable = false, Namespace = "")]
    public string CallNotifyEmailAddress {
        get => _callNotifyEmailAddress;
        set {
            CallNotifyEmailAddressSpecified = true;
            _callNotifyEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool CallNotifyEmailAddressSpecified { get; set; }
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
