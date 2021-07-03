using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Service Activation Access Code system parameters.
    /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
    /// <see cref="SystemServiceActivationAccessCodeGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15971""}]")]
    public class SystemServiceActivationAccessCodeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
