using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Physical Location system parameters.
    /// The response is either SystemPhysicalLocationGetResponse or ErrorResponse.
    /// <see cref="SystemPhysicalLocationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4a26e5fa0592a0fd3b4e60e9432f8588:43""}]")]
    public class SystemPhysicalLocationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
