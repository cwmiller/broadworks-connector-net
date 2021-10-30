using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Alternate Numbers.
    /// The response is either a UserAlternateNumbersGetResponse17 or an ErrorResponse.
    /// 
    /// Replaced by: UserAlternateNumbersGetRequest21 in AS data mode
    /// <see cref="UserAlternateNumbersGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserAlternateNumbersGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:12460""}]")]
    public class UserAlternateNumbersGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserAlternateNumbersGetResponse17>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12460")]
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
