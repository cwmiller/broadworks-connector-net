using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Integrated IMP service attributes.
    /// The response is either SystemIntegratedIMPGetResponse21 or ErrorResponse.
    /// Replaced by: SystemIntegratedIMPGetRequest25 in AS data mode.
    /// <see cref="SystemIntegratedIMPGetResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemIntegratedIMPGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemIntegratedIMPGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemIntegratedIMPGetResponse21>
    {

    }
}
