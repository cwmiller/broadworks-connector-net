using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallTransferGetRequest14sp4.
    /// <see cref="UserCallTransferGetRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6604ba4b5f755b1ba8d7de48e87c6e63:57""}]")]
    public class UserCallTransferGetResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isRecallActive;

        [XmlElement(ElementName = "isRecallActive", IsNullable = false, Namespace = "")]
        [Group(@"6604ba4b5f755b1ba8d7de48e87c6e63:57")]
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
        [Group(@"6604ba4b5f755b1ba8d7de48e87c6e63:57")]
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
        [Group(@"6604ba4b5f755b1ba8d7de48e87c6e63:57")]
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
        [Group(@"6604ba4b5f755b1ba8d7de48e87c6e63:57")]
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
        [Group(@"6604ba4b5f755b1ba8d7de48e87c6e63:57")]
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
        [Group(@"6604ba4b5f755b1ba8d7de48e87c6e63:57")]
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
