using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Dispatches the system refresh task on the local Application Server node.  At most one instance of the system refresh task may run on an Application Server node at a given point in time.  If the system refresh task is already running when this request is made, an ErrorResponse is returned.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16470""}]")]
    public class SystemShInterfaceRefreshTaskStartRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

    }
}
