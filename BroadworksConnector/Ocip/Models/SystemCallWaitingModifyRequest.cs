using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Waiting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e12337fe0480db757507a0699bc195d9:73""}]")]
    public class SystemCallWaitingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _playDistinctiveRingback;

        [XmlElement(ElementName = "playDistinctiveRingback", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e12337fe0480db757507a0699bc195d9:73")]
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
        public bool PlayDistinctiveRingbackSpecified { get; set; }

    }
}
