using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Multimedia Policy.
    /// The response is either a SystemMultimediaPolicyGetResponse or an
    /// ErrorResponse.
    /// Replaced by: SystemMultimediaPolicyGetRequestRI.
    /// <see cref="SystemMultimediaPolicyGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11465""}]")]
    public class SystemMultimediaPolicyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMultimediaPolicyGetResponse>
    {

    }
}
