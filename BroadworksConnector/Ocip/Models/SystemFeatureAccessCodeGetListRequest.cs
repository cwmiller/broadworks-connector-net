using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get list of default Feature Access Codes defined on system level.
    /// The response is either SystemFeatureAccessCodeGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemFeatureAccessCodeGetListRequest21 in AS data mode
    /// <see cref="SystemFeatureAccessCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemFeatureAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10353""}]")]
    public class SystemFeatureAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemFeatureAccessCodeGetListResponse>
    {

    }
}
