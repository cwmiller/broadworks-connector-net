using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Calling Party Category in system.
    /// The response is either a SystemCallingPartyCategoryGetListResponse or an ErrorResponse.
    /// <see cref="SystemCallingPartyCategoryGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d0efd2493d3062b292fd31759011925e:89""}]")]
    public class SystemCallingPartyCategoryGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallingPartyCategoryGetListResponse>
    {

    }
}
