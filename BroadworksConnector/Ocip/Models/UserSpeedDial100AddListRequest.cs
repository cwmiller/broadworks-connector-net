using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add one or more speed dial 100 settings for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""066a3d16bce438447d23cbe6ff0885a6:143""}]")]
    public class UserSpeedDial100AddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:143")]
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

        private List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> _speedDialEntry = new List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry>();

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:143")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial100Entry> SpeedDialEntry
        {
            get => _speedDialEntry;
            set
            {
                SpeedDialEntrySpecified = true;
                _speedDialEntry = value;
            }
        }

        [XmlIgnore]
        protected bool SpeedDialEntrySpecified { get; set; }

    }
}
