using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkGroupDeviceEndpointRead14sp4 
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _linePort;

    [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
    public string LinePort {
        get => _linePort;
        set {
            LinePortSpecified = true;
            _linePort = value;
        }
    }

    [XmlIgnore]
    public bool LinePortSpecified { get; set; }
    private string _contact;

    [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
    public string Contact {
        get => _contact;
        set {
            ContactSpecified = true;
            _contact = value;
        }
    }

    [XmlIgnore]
    public bool ContactSpecified { get; set; }
    private bool _staticRegistrationCapable;

    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
    public bool StaticRegistrationCapable {
        get => _staticRegistrationCapable;
        set {
            StaticRegistrationCapableSpecified = true;
            _staticRegistrationCapable = value;
        }
    }

    [XmlIgnore]
    public bool StaticRegistrationCapableSpecified { get; set; }
    private bool _useDomain;

    [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
    public bool UseDomain {
        get => _useDomain;
        set {
            UseDomainSpecified = true;
            _useDomain = value;
        }
    }

    [XmlIgnore]
    public bool UseDomainSpecified { get; set; }
    private bool _isPilotUser;

    [XmlElement(ElementName = "isPilotUser", IsNullable = false, Namespace = "")]
    public bool IsPilotUser {
        get => _isPilotUser;
        set {
            IsPilotUserSpecified = true;
            _isPilotUser = value;
        }
    }

    [XmlIgnore]
    public bool IsPilotUserSpecified { get; set; }
}
}
