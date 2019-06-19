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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:51""}]")]
    public class SystemBroadWorksReceptionistEnterpriseGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
