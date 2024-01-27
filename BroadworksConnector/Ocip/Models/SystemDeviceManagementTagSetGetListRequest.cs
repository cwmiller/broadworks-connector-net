using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of custom configuration tag sets managed by the Device Management System.
    /// The response is either SystemDeviceManagementTagSetGetListResponse or ErrorResponse.
    /// 
    /// Replaced by SystemDeviceManagementTagSetGetListRequest22 in AS data mode.
    /// <see cref="SystemDeviceManagementTagSetGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDeviceManagementTagSetGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9830""}]")]
    public class SystemDeviceManagementTagSetGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceManagementTagSetGetListResponse>
    {

    }
}
