using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHuntGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _anonymousInsteadOfPrivateCLID;

    [XmlElement(ElementName = "anonymousInsteadOfPrivateCLID", IsNullable = false, Namespace = "")]
    public bool AnonymousInsteadOfPrivateCLID {
        get => _anonymousInsteadOfPrivateCLID;
        set {
            AnonymousInsteadOfPrivateCLIDSpecified = true;
            _anonymousInsteadOfPrivateCLID = value;
        }
    }

    [XmlIgnore]
    public bool AnonymousInsteadOfPrivateCLIDSpecified { get; set; }
    private bool _removeHuntGroupNameFromCLID;

    [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false, Namespace = "")]
    public bool RemoveHuntGroupNameFromCLID {
        get => _removeHuntGroupNameFromCLID;
        set {
            RemoveHuntGroupNameFromCLIDSpecified = true;
            _removeHuntGroupNameFromCLID = value;
        }
    }

    [XmlIgnore]
    public bool RemoveHuntGroupNameFromCLIDSpecified { get; set; }
}
}
