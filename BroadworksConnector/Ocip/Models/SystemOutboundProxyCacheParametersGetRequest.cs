using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Outbound Proxy Cache system parameters.
    /// The response is either SystemOutboundProxyCacheParametersGetResponse or ErrorResponse.
    /// 
    /// Note that an error is returned if CloudPBX is not licensed.
    /// <see cref="SystemOutboundProxyCacheParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14227""}]")]
    public class SystemOutboundProxyCacheParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemOutboundProxyCacheParametersGetResponse>
    {

    }
}
