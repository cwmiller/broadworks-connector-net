using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of SMDI Servers defined in the system.
    /// The response is either a SystemSMDIMessageDeskGetServerListResponse or an ErrorResponse.
    /// <see cref="SystemSMDIMessageDeskGetServerListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:120""}]")]
    public class SystemSMDIMessageDeskGetServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
