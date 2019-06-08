using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAliasDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _aliasNetAddress;

    [XmlElement(ElementName = "aliasNetAddress", IsNullable = false, Namespace = "")]
    public string AliasNetAddress {
        get => _aliasNetAddress;
        set {
            AliasNetAddressSpecified = true;
            _aliasNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool AliasNetAddressSpecified { get; set; }
}
}
