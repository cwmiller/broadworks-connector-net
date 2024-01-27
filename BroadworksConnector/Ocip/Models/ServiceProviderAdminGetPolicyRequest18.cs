using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider administrator's policy settings.
    /// The response is either ServiceProviderAdminGetPolicyResponse18 or ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderAdminGetPolicyRequest20 in AS data mode
    /// <see cref="ServiceProviderAdminGetPolicyResponse18"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderAdminGetPolicyRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5953""}]")]
    public class ServiceProviderAdminGetPolicyRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderAdminGetPolicyResponse18>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5953")]
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
