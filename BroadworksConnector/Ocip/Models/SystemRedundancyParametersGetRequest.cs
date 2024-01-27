using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: SystemRedundancyParametersGetRequest16sp2
    /// 
    /// Request to get the list of Redundancy system parameters.
    /// The response is either SystemRedundancyParametersGetResponse or ErrorResponse.
    /// <see cref="SystemRedundancyParametersGetRequest16sp2"/>
    /// <see cref="SystemRedundancyParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29534""}]")]
    public class SystemRedundancyParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemRedundancyParametersGetResponse>
    {

    }
}
