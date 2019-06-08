using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostGuestAssociationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private bool _enforceAssociationLimit;

    [XmlElement(ElementName = "enforceAssociationLimit", IsNullable = false, Namespace = "")]
    public bool EnforceAssociationLimit {
        get => _enforceAssociationLimit;
        set {
            EnforceAssociationLimitSpecified = true;
            _enforceAssociationLimit = value;
        }
    }

    [XmlIgnore]
    public bool EnforceAssociationLimitSpecified { get; set; }
    private int _associationLimitHours;

    [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
    public int AssociationLimitHours {
        get => _associationLimitHours;
        set {
            AssociationLimitHoursSpecified = true;
            _associationLimitHours = value;
        }
    }

    [XmlIgnore]
    public bool AssociationLimitHoursSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel _accessLevel;

    [XmlElement(ElementName = "accessLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel AccessLevel {
        get => _accessLevel;
        set {
            AccessLevelSpecified = true;
            _accessLevel = value;
        }
    }

    [XmlIgnore]
    public bool AccessLevelSpecified { get; set; }
    private bool _removeGuestAssociation;

    [XmlElement(ElementName = "removeGuestAssociation", IsNullable = false, Namespace = "")]
    public bool RemoveGuestAssociation {
        get => _removeGuestAssociation;
        set {
            RemoveGuestAssociationSpecified = true;
            _removeGuestAssociation = value;
        }
    }

    [XmlIgnore]
    public bool RemoveGuestAssociationSpecified { get; set; }
}
}
