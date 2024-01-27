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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""65f35694d7d3354987bf6387ab55bfc6:103""}]")]
    public class SystemGroupNightForwardingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGroupNightForwardingGetResponse>
    {

    }
}
