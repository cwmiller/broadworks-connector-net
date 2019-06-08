using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksCommunicatorGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _configurationServerURL;

    [XmlElement(ElementName = "configurationServerURL", IsNullable = false, Namespace = "")]
    public string ConfigurationServerURL {
        get => _configurationServerURL;
        set {
            ConfigurationServerURLSpecified = true;
            _configurationServerURL = value;
        }
    }

    [XmlIgnore]
    public bool ConfigurationServerURLSpecified { get; set; }
}
}
