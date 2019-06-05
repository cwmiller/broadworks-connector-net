using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ChangeCallForwardingDestinationMenuKeys 
{
    private string _finishEnteringNewDestinationNumber;

    [XmlElement(ElementName = "finishEnteringNewDestinationNumber", IsNullable = false, Namespace = "")]
    public string FinishEnteringNewDestinationNumber {
        get => _finishEnteringNewDestinationNumber;
        set {
            FinishEnteringNewDestinationNumberSpecified = true;
            _finishEnteringNewDestinationNumber = value;
        }
    }

    [XmlIgnore]
    public bool FinishEnteringNewDestinationNumberSpecified { get; set; }
}
}
