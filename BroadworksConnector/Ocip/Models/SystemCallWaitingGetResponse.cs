using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallWaitingGetRequest.
    /// <see cref="SystemCallWaitingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e12337fe0480db757507a0699bc195d9:57""}]")]
    public class SystemCallWaitingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _playDistinctiveRingback;

        [XmlElement(ElementName = "playDistinctiveRingback", IsNullable = false, Namespace = "")]
        [Group(@"e12337fe0480db757507a0699bc195d9:57")]
        public bool PlayDistinctiveRingback
        {
            get => _playDistinctiveRingback;
            set
            {
                PlayDistinctiveRingbackSpecified = true;
                _playDistinctiveRingback = value;
            }
        }

        [XmlIgnore]
        protected bool PlayDistinctiveRingbackSpecified { get; set; }

    }
}
