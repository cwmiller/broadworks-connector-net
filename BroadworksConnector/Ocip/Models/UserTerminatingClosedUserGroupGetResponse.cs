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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4126""}]")]
    public class UserTerminatingClosedUserGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _userInterlockCode;

        [XmlElement(ElementName = "userInterlockCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4126")]
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
