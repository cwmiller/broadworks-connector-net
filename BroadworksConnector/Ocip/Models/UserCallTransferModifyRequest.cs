using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Call Transfer.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a0da3cd21ff9c39efcb7d6d9f013f8b:78""}]")]
    public class UserCallTransferModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
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

        protected bool _isRecallActive;

        [XmlElement(ElementName = "isRecallActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
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

        protected int _recallNumberOfRings;

        [XmlElement(ElementName = "recallNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
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

        protected bool _useDiversionInhibitorForBlindTransfer;

        [XmlElement(ElementName = "useDiversionInhibitorForBlindTransfer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
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

        protected bool _useDiversionInhibitorForConsultativeCalls;

        [XmlElement(ElementName = "useDiversionInhibitorForConsultativeCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
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

        protected bool _enableBusyCampOn;

        [XmlElement(ElementName = "enableBusyCampOn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
        public bool EnableBusyCampOn
        {
            get => _enableBusyCampOn;
            set
            {
                EnableBusyCampOnSpecified = true;
                _enableBusyCampOn = value;
            }
        }

        [XmlIgnore]
        protected bool EnableBusyCampOnSpecified { get; set; }

        protected int _busyCampOnSeconds;

        [XmlElement(ElementName = "busyCampOnSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a0da3cd21ff9c39efcb7d6d9f013f8b:78")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int BusyCampOnSeconds
        {
            get => _busyCampOnSeconds;
            set
            {
                BusyCampOnSecondsSpecified = true;
                _busyCampOnSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool BusyCampOnSecondsSpecified { get; set; }

    }
}
