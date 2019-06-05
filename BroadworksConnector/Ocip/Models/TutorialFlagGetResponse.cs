using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TutorialFlagGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableTutorial;

    [XmlElement(ElementName = "enableTutorial", IsNullable = false, Namespace = "")]
    public bool EnableTutorial {
        get => _enableTutorial;
        set {
            EnableTutorialSpecified = true;
            _enableTutorial = value;
        }
    }

    [XmlIgnore]
    public bool EnableTutorialSpecified { get; set; }
}
}
