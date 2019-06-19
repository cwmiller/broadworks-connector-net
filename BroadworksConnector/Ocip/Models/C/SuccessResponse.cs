using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The SuccessResponse is concrete response sent whenever a transaction is successful and does not return any data.
    /// <see cref="SuccessResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:165""}]")]
    public class SuccessResponse : BroadWorksConnector.Ocip.Models.C.OCIResponse
    {

    }
}
