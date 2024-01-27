using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete one or more speed dial 100 settings for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e084de202cf726c3202fca43390f9ec5:160""}]")]
    public class UserSpeedDial100DeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e084de202cf726c3202fca43390f9ec5:160")]
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

        protected List<int> _speedCode = new List<int>();

        [XmlElement(ElementName = "speedCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e084de202cf726c3202fca43390f9ec5:160")]
        [MinInclusive(0)]
        [MaxInclusive(99)]
        public List<int> SpeedCode
        {
            get => _speedCode;
            set
            {
                SpeedCodeSpecified = true;
                _speedCode = value;
            }
        }

        [XmlIgnore]
        protected bool SpeedCodeSpecified { get; set; }

    }
}
