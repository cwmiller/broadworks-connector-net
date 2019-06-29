using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get speed dial 100 settings for a speed code.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""066a3d16bce438447d23cbe6ff0885a6:209""}]")]
    public class UserSpeedDial100GetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:209")]
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

        private int _speedCode;

        [XmlElement(ElementName = "speedCode", IsNullable = false, Namespace = "")]
        [Group(@"066a3d16bce438447d23cbe6ff0885a6:209")]
        [MinInclusive(0)]
        [MaxInclusive(99)]
        public int SpeedCode
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
