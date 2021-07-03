using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallTransferGetRequest.
    /// <see cref="UserCallTransferGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41784""}]")]
    public class UserCallTransferGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isRecallActive;

        [XmlElement(ElementName = "isRecallActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41784")]
        public bool IsRecallActive
        {
            get => _isRecallActive;
            set
            {
                IsRecallActiveSpecified = true;
                _isRecallActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsRecallActiveSpecified { get; set; }

        private int _recallNumberOfRings;

        [XmlElement(ElementName = "recallNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41784")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int RecallNumberOfRings
        {
            get => _recallNumberOfRings;
            set
            {
                RecallNumberOfRingsSpecified = true;
                _recallNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool RecallNumberOfRingsSpecified { get; set; }

        private bool _useDiversionInhibitorForBlindTransfer;

        [XmlElement(ElementName = "useDiversionInhibitorForBlindTransfer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41784")]
        public bool UseDiversionInhibitorForBlindTransfer
        {
            get => _useDiversionInhibitorForBlindTransfer;
            set
            {
                UseDiversionInhibitorForBlindTransferSpecified = true;
                _useDiversionInhibitorForBlindTransfer = value;
            }
        }

        [XmlIgnore]
        protected bool UseDiversionInhibitorForBlindTransferSpecified { get; set; }

        private bool _useDiversionInhibitorForConsultativeCalls;

        [XmlElement(ElementName = "useDiversionInhibitorForConsultativeCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41784")]
        public bool UseDiversionInhibitorForConsultativeCalls
        {
            get => _useDiversionInhibitorForConsultativeCalls;
            set
            {
                UseDiversionInhibitorForConsultativeCallsSpecified = true;
                _useDiversionInhibitorForConsultativeCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseDiversionInhibitorForConsultativeCallsSpecified { get; set; }

    }
}
