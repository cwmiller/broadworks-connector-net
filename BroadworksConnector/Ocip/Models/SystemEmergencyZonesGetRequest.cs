using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Emergency Zones.
    /// The response is either a SystemEmergencyZonesGetResponse or an
    /// ErrorResponse.
    /// <see cref="SystemEmergencyZonesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e71c2205fb31894f87810b330a85ede2:261""}]")]
    public class SystemEmergencyZonesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
