using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAutomaticHoldRetrieveGetRequest.
    /// <see cref="UserAutomaticHoldRetrieveGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7e6893393b21480206131a5d901c0eef:59""}]")]
    public class UserAutomaticHoldRetrieveGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"7e6893393b21480206131a5d901c0eef:59")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected int _recallTimerSeconds;

        [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7e6893393b21480206131a5d901c0eef:59")]
        [MinInclusive(6)]
        [MaxInclusive(600)]
        public int RecallTimerSeconds
        {
            get => _recallTimerSeconds;
            set
            {
                RecallTimerSecondsSpecified = true;
                _recallTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RecallTimerSecondsSpecified { get; set; }

    }
}
