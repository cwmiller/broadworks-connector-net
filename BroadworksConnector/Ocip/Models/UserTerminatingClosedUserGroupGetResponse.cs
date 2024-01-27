using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserTerminatingClosedUserGroupGetRequest.
    /// Returns user Terminating CUG service settings.
    /// <see cref="UserTerminatingClosedUserGroupGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4135""}]")]
    public class UserTerminatingClosedUserGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _userInterlockCode;

        [XmlElement(ElementName = "userInterlockCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4135")]
        [Length(4)]
        public string UserInterlockCode
        {
            get => _userInterlockCode;
            set
            {
                UserInterlockCodeSpecified = true;
                _userInterlockCode = value;
            }
        }

        [XmlIgnore]
        protected bool UserInterlockCodeSpecified { get; set; }

    }
}
