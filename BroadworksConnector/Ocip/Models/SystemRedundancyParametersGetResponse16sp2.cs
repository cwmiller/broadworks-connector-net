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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15123""}]")]
    public class SystemRedundancyParametersGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _rollBackTimerMinutes;

        [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15123")]
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

        protected bool _sendSipOptionMessageUponMigration;

        [XmlElement(ElementName = "sendSipOptionMessageUponMigration", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15123")]
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
