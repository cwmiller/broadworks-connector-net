using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGetRegistrationContactListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _registrationTable;

    [XmlElement(ElementName = "registrationTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RegistrationTable {
        get => _registrationTable;
        set {
            RegistrationTableSpecified = true;
            _registrationTable = value;
        }
    }

    [XmlIgnore]
    public bool RegistrationTableSpecified { get; set; }
}
}
