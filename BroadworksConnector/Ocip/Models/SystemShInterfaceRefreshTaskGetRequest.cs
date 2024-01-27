using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrieves the status of the system refresh task on the local Application Server node.
    /// The response is either a SystemShInterfaceRefreshTaskGetResponse or an ErrorResponse.
    /// <see cref="SystemShInterfaceRefreshTaskGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16659""}]")]
    public class SystemShInterfaceRefreshTaskGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemShInterfaceRefreshTaskGetResponse>
    {

    }
}
