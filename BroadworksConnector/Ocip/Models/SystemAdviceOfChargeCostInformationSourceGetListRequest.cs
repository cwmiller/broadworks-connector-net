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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9975efc7f5883a0595f811ee72ba4df5:187""}]")]
    public class SystemAdviceOfChargeCostInformationSourceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAdviceOfChargeCostInformationSourceGetListResponse>
    {

    }
}
