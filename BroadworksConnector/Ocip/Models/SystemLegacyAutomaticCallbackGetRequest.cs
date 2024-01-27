using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's legacy automatic callback attributes.
    /// The response is either a SystemLegacyAutomaticCallbackGetResponse or an ErrorResponse.
    /// <see cref="SystemLegacyAutomaticCallbackGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dd4a5e667a0f0e4bd6363152331d07ab:78""}]")]
    public class SystemLegacyAutomaticCallbackGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLegacyAutomaticCallbackGetResponse>
    {

    }
}
