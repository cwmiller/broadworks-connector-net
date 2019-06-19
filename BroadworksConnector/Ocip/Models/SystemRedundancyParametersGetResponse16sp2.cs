using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRedundancyParametersGetRequest16sp2.
    /// Contains a list of system Redundancy parameters.
    /// <see cref="SystemRedundancyParametersGetRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13811""}]")]
    public class SystemRedundancyParametersGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _rollBackTimerMinutes;

        [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13811")]
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
        public bool RollBackTimerMinutesSpecified { get; set; }

        private bool _sendSipOptionMessageUponMigration;

        [XmlElement(ElementName = "sendSipOptionMessageUponMigration", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13811")]
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
        public bool SendSipOptionMessageUponMigrationSpecified { get; set; }

    }
}
