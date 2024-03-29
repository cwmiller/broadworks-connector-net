using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse or an ErrorResponse.
    /// Replaced By: SystemAutomaticCallbackGetRequest15
    /// <see cref="SystemAutomaticCallbackGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAutomaticCallbackGetRequest15"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20611""}]")]
    public class SystemAutomaticCallbackGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAutomaticCallbackGetResponse>
    {

    }
}
