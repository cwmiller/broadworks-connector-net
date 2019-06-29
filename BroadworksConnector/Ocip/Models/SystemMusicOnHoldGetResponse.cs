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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""66fe518a637c74cc4b2c97aa7f68fc49:206""}]")]
    public class SystemMusicOnHoldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _delayMilliseconds;

        [XmlElement(ElementName = "delayMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:206")]
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
