using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Originating Rule
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47792""}]")]
    public class CommunicationBarringOriginatingRule15sp2
    {

        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47792")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Criteria
        {
            get => _criteria;
            set
            {
                CriteriaSpecified = true;
                _criteria = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47792")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction15sp2 Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        protected bool ActionSpecified { get; set; }

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47792")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

        private string _transferNumber;

        [XmlElement(ElementName = "transferNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47792")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferNumber
        {
            get => _transferNumber;
            set
            {
                TransferNumberSpecified = true;
                _transferNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferNumberSpecified { get; set; }

    }
}
