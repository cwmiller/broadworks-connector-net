using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMusicOnHoldGetRequest.
        /// <see cref="SystemMusicOnHoldGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMusicOnHoldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _delayMilliseconds;

        [XmlElement(ElementName = "delayMilliseconds", IsNullable = false, Namespace = "")]
        public int DelayMilliseconds {
            get => _delayMilliseconds;
            set {
                DelayMillisecondsSpecified = true;
                _delayMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayMillisecondsSpecified { get; set; }
        
    }
}
