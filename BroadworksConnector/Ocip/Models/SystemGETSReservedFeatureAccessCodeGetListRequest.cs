using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of GETS reserved FAC.
    /// The response is either SystemGETSReservedFeatureAccessCodeGetListResponse or ErrorResponse.
    /// <see cref="SystemGETSReservedFeatureAccessCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemGETSReservedFeatureAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
