using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetReleaseCauseListResponse or an ErrorResponse.
    /// <see cref="SystemAutomaticCallbackGetReleaseCauseListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e8188f390ad4fcfad616cb409dd0e896:78""}]")]
    public class SystemAutomaticCallbackGetReleaseCauseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
