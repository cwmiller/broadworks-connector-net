using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Application Server Registration system parameters.
    /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
    /// 
    /// Replaced by: SystemASRParametersGetRequest23 in AS data mode.
    /// <see cref="SystemASRParametersGetResponse14sp7"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemASRParametersGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:8261""}]")]
    public class SystemASRParametersGetRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemASRParametersGetResponse14sp7>
    {

    }
}
