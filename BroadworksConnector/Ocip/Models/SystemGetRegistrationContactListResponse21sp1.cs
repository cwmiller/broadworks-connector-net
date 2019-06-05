using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGetRegistrationContactListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _registrationTable;

    [XmlElement(ElementName = "registrationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RegistrationTable {
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
