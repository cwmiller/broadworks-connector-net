using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the default Xsi policy profile for a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4191""}]")]
    public class UserXsiPolicyProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4191")]
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

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey _xsiPolicyProfile;

        [XmlElement(ElementName = "xsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4191")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey XsiPolicyProfile
        {
            get => _xsiPolicyProfile;
            set
            {
                XsiPolicyProfileSpecified = true;
                _xsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool XsiPolicyProfileSpecified { get; set; }

    }
}
