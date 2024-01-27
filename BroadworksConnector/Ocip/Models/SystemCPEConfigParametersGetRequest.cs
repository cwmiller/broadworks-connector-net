using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of CPE Config system parameters.
    /// The response is either SystemCPEConfigParametersGetResponse or ErrorResponse.
    /// Replaced By: SystemCPEConfigParametersGetRequest14sp6
    /// <see cref="SystemCPEConfigParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCPEConfigParametersGetRequest14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:25832""}]")]
    public class SystemCPEConfigParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse>
    {

    }
}
