using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVideoServerParametersGetRequest.
    /// Contains a list of system video server parameters.
        /// <see cref="SystemVideoServerParametersGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVideoServerParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _videoServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        public int VideoServerResponseTimerMilliseconds {
            get => _videoServerResponseTimerMilliseconds;
            set {
                VideoServerResponseTimerMillisecondsSpecified = true;
                _videoServerResponseTimerMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool VideoServerResponseTimerMillisecondsSpecified { get; set; }
        
        private int _videoServerSelectionRouteTimerMilliseconds;

        [XmlElement(ElementName = "videoServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
        public int VideoServerSelectionRouteTimerMilliseconds {
            get => _videoServerSelectionRouteTimerMilliseconds;
            set {
                VideoServerSelectionRouteTimerMillisecondsSpecified = true;
                _videoServerSelectionRouteTimerMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool VideoServerSelectionRouteTimerMillisecondsSpecified { get; set; }
        
        private bool _useStaticVideoServerDevice;

        [XmlElement(ElementName = "useStaticVideoServerDevice", IsNullable = false, Namespace = "")]
        public bool UseStaticVideoServerDevice {
            get => _useStaticVideoServerDevice;
            set {
                UseStaticVideoServerDeviceSpecified = true;
                _useStaticVideoServerDevice = value;
            }
        }

        [XmlIgnore]
        public bool UseStaticVideoServerDeviceSpecified { get; set; }
        
    }
}
