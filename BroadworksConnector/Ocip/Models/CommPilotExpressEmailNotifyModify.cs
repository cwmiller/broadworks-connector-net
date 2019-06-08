using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressEmailNotifyModify 
{
    private bool _sendEmail;

    [XmlElement(ElementName = "sendEmail", IsNullable = false, Namespace = "")]
    public bool SendEmail {
        get => _sendEmail;
        set {
            SendEmailSpecified = true;
            _sendEmail = value;
        }
    }

    [XmlIgnore]
    public bool SendEmailSpecified { get; set; }
    private string _emailAddress;

    [XmlElement(ElementName = "emailAddress", IsNullable = true, Namespace = "")]
    public string EmailAddress {
        get => _emailAddress;
        set {
            EmailAddressSpecified = true;
            _emailAddress = value;
        }
    }

    [XmlIgnore]
    public bool EmailAddressSpecified { get; set; }
}
}
