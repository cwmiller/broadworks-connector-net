using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Redundancy system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13828""}]")]
    public class SystemRedundancyParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _rollBackTimerMinutes;

        [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13828")]
        [MinInclusive(0)]
        [MaxInclusive(3600)]
        public int RollBackTimerMinutes
        {
            get => _rollBackTimerMinutes;
            set
            {
                RollBackTimerMinutesSpecified = true;
                _rollBackTimerMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool RollBackTimerMinutesSpecified { get; set; }

        private bool _sendSipOptionMessageUponMigration;

        [XmlElement(ElementName = "sendSipOptionMessageUponMigration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13828")]
        public bool SendSipOptionMessageUponMigration
        {
            get => _sendSipOptionMessageUponMigration;
            set
            {
                SendSipOptionMessageUponMigrationSpecified = true;
                _sendSipOptionMessageUponMigration = value;
            }
        }

        [XmlIgnore]
        protected bool SendSipOptionMessageUponMigrationSpecified { get; set; }

    }
}
