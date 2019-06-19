using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of system service DNs not yet in use.
    /// The response is either SystemSystemServiceDnGetAvailableListResponse or ErrorResponse.
    /// <see cref="SystemSystemServiceDnGetAvailableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemSystemServiceDnGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
