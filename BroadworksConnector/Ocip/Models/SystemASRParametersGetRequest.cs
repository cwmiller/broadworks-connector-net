using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Application Server Registration system parameters.
    /// The response is either SystemASRParametersGetResponse or ErrorResponse.
    /// Replaced By: SystemASRParametersGetRequest14sp5
    /// <see cref="SystemASRParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemASRParametersGetRequest14sp5"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20525""}]")]
    public class SystemASRParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemASRParametersGetResponse>
    {

    }
}
