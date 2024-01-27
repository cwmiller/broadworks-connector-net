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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:42393""}]")]
    public class UserCallTransferGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isRecallActive;

        [XmlElement(ElementName = "isRecallActive", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42393")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:42393")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:42393")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:42393")]
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
