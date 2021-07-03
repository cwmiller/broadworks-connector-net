using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse22V3 or an ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityGetResponse22V3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1031""}]")]
    public class SystemBroadWorksMobilityGetRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
