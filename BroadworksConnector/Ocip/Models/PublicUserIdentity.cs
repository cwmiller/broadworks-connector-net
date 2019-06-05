using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PublicUserIdentity 
{
    private string _sipURI;

    [XmlElement(ElementName = "sipURI", IsNullable = false, Namespace = "")]
    public string SipURI {
        get => _sipURI;
        set {
            SipURISpecified = true;
            _sipURI = value;
        }
    }

    [XmlIgnore]
    public bool SipURISpecified { get; set; }
    private string _telURI;

    [XmlElement(ElementName = "telURI", IsNullable = false, Namespace = "")]
    public string TelURI {
        get => _telURI;
        set {
            TelURISpecified = true;
            _telURI = value;
        }
    }

    [XmlIgnore]
    public bool TelURISpecified { get; set; }
}
}
