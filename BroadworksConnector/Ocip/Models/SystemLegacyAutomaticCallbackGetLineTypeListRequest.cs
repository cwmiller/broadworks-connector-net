using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's legacy automatic callback line type settings.
    /// The response is either a SystemLegacyAutomaticCallbackGetLineTypeListResponse or an ErrorResponse.
    /// <see cref="SystemLegacyAutomaticCallbackGetLineTypeListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bf3c0ead6c4d948122ea83af7fc6e34:48""}]")]
    public class SystemLegacyAutomaticCallbackGetLineTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLegacyAutomaticCallbackGetLineTypeListResponse>
    {

    }
}
