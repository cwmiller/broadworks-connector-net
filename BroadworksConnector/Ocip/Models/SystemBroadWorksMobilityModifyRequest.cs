using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the BroadWorks Mobility system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemBroadWorksMobilityModifyRequest17sp4.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityModifyRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _enableLocationServices;

        [XmlElement(ElementName = "enableLocationServices", IsNullable = false, Namespace = "")]
        public bool EnableLocationServices {
            get => _enableLocationServices;
            set {
                EnableLocationServicesSpecified = true;
                _enableLocationServices = value;
            }
        }

        [XmlIgnore]
        public bool EnableLocationServicesSpecified { get; set; }
        
        private bool _enableMSRNLookup;

        [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false, Namespace = "")]
        public bool EnableMSRNLookup {
            get => _enableMSRNLookup;
            set {
                EnableMSRNLookupSpecified = true;
                _enableMSRNLookup = value;
            }
        }

        [XmlIgnore]
        public bool EnableMSRNLookupSpecified { get; set; }
        
        private bool _enableMobileStateChecking;

        [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false, Namespace = "")]
        public bool EnableMobileStateChecking {
            get => _enableMobileStateChecking;
            set {
                EnableMobileStateCheckingSpecified = true;
                _enableMobileStateChecking = value;
            }
        }

        [XmlIgnore]
        public bool EnableMobileStateCheckingSpecified { get; set; }
        
        private bool _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        public bool DenyCallOriginations {
            get => _denyCallOriginations;
            set {
                DenyCallOriginationsSpecified = true;
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallOriginationsSpecified { get; set; }
        
        private bool _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        public bool DenyCallTerminations {
            get => _denyCallTerminations;
            set {
                DenyCallTerminationsSpecified = true;
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallTerminationsSpecified { get; set; }
        
        private int _imrnTimeoutMilliseconds;

        [XmlElement(ElementName = "imrnTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        public int ImrnTimeoutMilliseconds {
            get => _imrnTimeoutMilliseconds;
            set {
                ImrnTimeoutMillisecondsSpecified = true;
                _imrnTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool ImrnTimeoutMillisecondsSpecified { get; set; }
        
        private string _scfSignalingIPAddress;

        [XmlElement(ElementName = "scfSignalingIPAddress", IsNullable = true, Namespace = "")]
        public string ScfSignalingIPAddress {
            get => _scfSignalingIPAddress;
            set {
                ScfSignalingIPAddressSpecified = true;
                _scfSignalingIPAddress = value;
            }
        }

        [XmlIgnore]
        public bool ScfSignalingIPAddressSpecified { get; set; }
        
        private int? _scfSignalingPort;

        [XmlElement(ElementName = "scfSignalingPort", IsNullable = true, Namespace = "")]
        public int? ScfSignalingPort {
            get => _scfSignalingPort;
            set {
                ScfSignalingPortSpecified = true;
                _scfSignalingPort = value;
            }
        }

        [XmlIgnore]
        public bool ScfSignalingPortSpecified { get; set; }
        
    }
}
