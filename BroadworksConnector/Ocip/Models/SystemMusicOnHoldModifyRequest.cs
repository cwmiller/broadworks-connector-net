using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Music On Hold.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a0309eb8d406fefc891f554ef114669:229""}]")]
    public class SystemMusicOnHoldModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _delayMilliseconds;

        [XmlElement(ElementName = "delayMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:229")]
        [MinInclusive(0)]
        [MaxInclusive(5000)]
        public int DelayMilliseconds
        {
            get => _delayMilliseconds;
            set
            {
                DelayMillisecondsSpecified = true;
                _delayMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool DelayMillisecondsSpecified { get; set; }

    }
}
