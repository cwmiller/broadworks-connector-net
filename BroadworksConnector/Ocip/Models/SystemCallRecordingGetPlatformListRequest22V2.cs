using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all system-level call recording platforms and all reseller level call recording platforms.
    /// If an excludeReseller is specified, returns all the system-level call recording platforms only.
    /// If a resellerId is specified, returns all the system-level call recording platforms and the given reseller's call recording platforms.
    /// If a reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// The response is either SystemCallRecordingGetPlatformListResponse22V2 or ErrorResponse.
        /// <see cref="SystemCallRecordingGetPlatformListResponse22V2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingGetPlatformListRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _excludeReseller;

        [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
        public bool ExcludeReseller {
            get => _excludeReseller;
            set {
                ExcludeResellerSpecified = true;
                _excludeReseller = value;
            }
        }

        [XmlIgnore]
        public bool ExcludeResellerSpecified { get; set; }
        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
