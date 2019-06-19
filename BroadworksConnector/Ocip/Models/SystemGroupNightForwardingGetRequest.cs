using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Group Night Forwarding system parameters.
    /// The response is either SystemGroupNightForwardingGetResponse or ErrorResponse.
    /// <see cref="SystemGroupNightForwardingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1a3849774e8d2ffd90c3a2c57cbdd7a0:103""}]")]
    public class SystemGroupNightForwardingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
