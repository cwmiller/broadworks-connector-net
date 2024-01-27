using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns the Sh non-transparent data stored against a userId.
    /// The response is either a UserShInterfaceGetUserIdDataResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserShInterfaceGetUserIdDataRequest21sp1 in AS data mode.
    /// <see cref="UserShInterfaceGetUserIdDataResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserShInterfaceGetUserIdDataRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18874""}]")]
    public class UserShInterfaceGetUserIdDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserShInterfaceGetUserIdDataResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18874")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

    }
}
