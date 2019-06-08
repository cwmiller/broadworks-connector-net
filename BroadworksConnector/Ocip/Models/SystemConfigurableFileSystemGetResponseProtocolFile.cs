using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponseProtocolFile 
{
    private bool _replicated;

    [XmlElement(ElementName = "replicated", IsNullable = false, Namespace = "")]
    public bool Replicated {
        get => _replicated;
        set {
            ReplicatedSpecified = true;
            _replicated = value;
        }
    }

    [XmlIgnore]
    public bool ReplicatedSpecified { get; set; }
}
}
