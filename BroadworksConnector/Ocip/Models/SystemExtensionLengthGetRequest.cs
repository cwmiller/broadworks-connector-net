using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's extension range.
    /// The response is either a SystemExtensionLengthGetResponse or an ErrorResponse.
    /// <see cref="SystemExtensionLengthGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemExtensionLengthGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
