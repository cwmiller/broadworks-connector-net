using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Intercept User dns defined in the system.
    /// The response is either a SystemInterceptUserGetDnListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemInterceptUserGetDnListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:176""}]")]
    public class SystemInterceptUserGetDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
