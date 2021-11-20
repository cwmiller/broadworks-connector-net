using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrieves the Sh Interface system parameters.
    /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemShInterfaceParametersGetRequest17
    /// <see cref="SystemShInterfaceParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemShInterfaceParametersGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:29347""}]")]
    public class SystemShInterfaceParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemShInterfaceParametersGetResponse>
    {

    }
}
