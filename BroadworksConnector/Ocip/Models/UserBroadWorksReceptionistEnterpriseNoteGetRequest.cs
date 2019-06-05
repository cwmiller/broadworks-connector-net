using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistEnterpriseNoteGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _receptionistUserId;

    [XmlElement(ElementName = "receptionistUserId", IsNullable = false, Namespace = "")]
    public string ReceptionistUserId {
        get => _receptionistUserId;
        set {
            ReceptionistUserIdSpecified = true;
            _receptionistUserId = value;
        }
    }

    [XmlIgnore]
    public bool ReceptionistUserIdSpecified { get; set; }
    private string _contactUserId;

    [XmlElement(ElementName = "contactUserId", IsNullable = false, Namespace = "")]
    public string ContactUserId {
        get => _contactUserId;
        set {
            ContactUserIdSpecified = true;
            _contactUserId = value;
        }
    }

    [XmlIgnore]
    public bool ContactUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.VirtualOnNetUserKey _vonUser;

    [XmlElement(ElementName = "vonUser", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VirtualOnNetUserKey VonUser {
        get => _vonUser;
        set {
            VonUserSpecified = true;
            _vonUser = value;
        }
    }

    [XmlIgnore]
    public bool VonUserSpecified { get; set; }
}
}
