using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementSIPAliasList 
{
    private List<string> _sipAlias;

    [XmlElement(ElementName = "sipAlias", IsNullable = false, Namespace = "")]
    public List<string> SipAlias {
        get => _sipAlias;
        set {
            SipAliasSpecified = true;
            _sipAlias = value;
        }
    }

    [XmlIgnore]
    public bool SipAliasSpecified { get; set; }
}
}
