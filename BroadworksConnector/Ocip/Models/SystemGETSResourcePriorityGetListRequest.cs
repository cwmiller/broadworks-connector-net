using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of GETS Resource Priorities.
    /// The response is either SystemGETSResourcePriorityGetListResponse or ErrorResponse.
    /// <see cref="SystemGETSResourcePriorityGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemGETSResourcePriorityGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
