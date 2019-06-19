using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system-level intercept user service settings.
    /// The response is either a SystemInterceptUserGetResponse or an ErrorResponse.
    /// <see cref="SystemInterceptUserGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:206""}]")]
    public class SystemInterceptUserGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
