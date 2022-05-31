using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserModifyGroupIdRequest.
    /// error indicates the failing conditions preventing the user move.
    /// impact indicates any change to user and group as the result of a user move.
    /// <see cref="UserModifyGroupIdRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2516""}]")]
    public class UserModifyGroupIdResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.UserMoveMessage> _error = new List<BroadWorksConnector.Ocip.Models.UserMoveMessage>();

        [XmlElement(ElementName = "error", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2516")]
        public List<BroadWorksConnector.Ocip.Models.UserMoveMessage> Error
        {
            get => _error;
            set
            {
                ErrorSpecified = true;
                _error = value;
            }
        }

        [XmlIgnore]
        protected bool ErrorSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserMoveMessage> _impact = new List<BroadWorksConnector.Ocip.Models.UserMoveMessage>();

        [XmlElement(ElementName = "impact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2516")]
        public List<BroadWorksConnector.Ocip.Models.UserMoveMessage> Impact
        {
            get => _impact;
            set
            {
                ImpactSpecified = true;
                _impact = value;
            }
        }

        [XmlIgnore]
        protected bool ImpactSpecified { get; set; }

    }
}
