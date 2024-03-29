using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of BroadWorks Receptionist - Enterprise parameters.
    /// The response is either SystemBroadWorksReceptionistEnterpriseGetResponse or ErrorResponse.
    /// <see cref="SystemBroadWorksReceptionistEnterpriseGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""44477d346d2631b033071e12af214ac8:51""}]")]
    public class SystemBroadWorksReceptionistEnterpriseGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksReceptionistEnterpriseGetResponse>
    {

    }
}
