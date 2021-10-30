using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Integrated IMP specific service attribute for the user.
    /// The response is either UserIntegratedIMPGetResponse or ErrorResponse.
    /// 
    /// Replaced by: UserIntegratedIMPGetRequest21sp1
    /// <see cref="UserIntegratedIMPGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserIntegratedIMPGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:13759""}]")]
    public class UserIntegratedIMPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserIntegratedIMPGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:13759")]
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
