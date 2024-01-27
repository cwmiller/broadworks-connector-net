using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMusicOnHoldGetRequest.
    /// <see cref="SystemMusicOnHoldGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a0309eb8d406fefc891f554ef114669:213""}]")]
    public class SystemMusicOnHoldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _delayMilliseconds;

        [XmlElement(ElementName = "delayMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"3a0309eb8d406fefc891f554ef114669:213")]
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
