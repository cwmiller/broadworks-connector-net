using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallForwardingSelectiveGetRequest. The criteria table's column headings are:
    /// "Is Active", "Criteria Name", "Time Schedule", "Calls From" and "Forward To".
    /// <see cref="UserCallForwardingSelectiveGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:10974""}]")]
    public class UserCallForwardingSelectiveGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultForwardToPhoneNumber;

        [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10974")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DefaultForwardToPhoneNumber
        {
            get => _defaultForwardToPhoneNumber;
            set
            {
                DefaultForwardToPhoneNumberSpecified = true;
                _defaultForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultForwardToPhoneNumberSpecified { get; set; }

        private bool _playRingReminder;

        [XmlElement(ElementName = "playRingReminder", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10974")]
        public bool PlayRingReminder
        {
            get => _playRingReminder;
            set
            {
                PlayRingReminderSpecified = true;
                _playRingReminder = value;
            }
        }

        [XmlIgnore]
        protected bool PlayRingReminderSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10974")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaTableSpecified { get; set; }

    }
}
