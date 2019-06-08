using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConnectedLineIdentificationPresentationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enforceUserServiceAssignment;

    [XmlElement(ElementName = "enforceUserServiceAssignment", IsNullable = false, Namespace = "")]
    public bool EnforceUserServiceAssignment {
        get => _enforceUserServiceAssignment;
        set {
            EnforceUserServiceAssignmentSpecified = true;
            _enforceUserServiceAssignment = value;
        }
    }

    [XmlIgnore]
    public bool EnforceUserServiceAssignmentSpecified { get; set; }
}
}
