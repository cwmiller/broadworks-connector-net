using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of cost information sources.
    /// The response is either SystemAdviceOfChargeCostInformationSourceGetListResponse or ErrorResponse.
    /// <see cref="SystemAdviceOfChargeCostInformationSourceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:187""}]")]
    public class SystemAdviceOfChargeCostInformationSourceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
