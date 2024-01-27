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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""08ee5b5ec09321975436b908fd540e7f:57""}]")]
    public class SystemCallWaitingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _playDistinctiveRingback;

        [XmlElement(ElementName = "playDistinctiveRingback", IsNullable = false, Namespace = "")]
        [Group(@"08ee5b5ec09321975436b908fd540e7f:57")]
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
