using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Redundancy system parameters.
    /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
    /// <see cref="SystemRedundancyParametersGetResponse16sp2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15109""}]")]
    public class SystemRedundancyParametersGetRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemRedundancyParametersGetResponse16sp2>
    {

    }
}
