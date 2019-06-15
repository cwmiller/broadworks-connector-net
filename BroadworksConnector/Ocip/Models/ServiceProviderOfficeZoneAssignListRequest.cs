using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assign a list of Office Zones to a service provider.
    /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
    /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderOfficeZoneAssignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private List<string> _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        public List<string> OfficeZoneName {
            get => _officeZoneName;
            set {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneNameSpecified { get; set; }
        
        private string _defaultOfficeZoneName;

        [XmlElement(ElementName = "defaultOfficeZoneName", IsNullable = false, Namespace = "")]
        public string DefaultOfficeZoneName {
            get => _defaultOfficeZoneName;
            set {
                DefaultOfficeZoneNameSpecified = true;
                _defaultOfficeZoneName = value;
            }
        }

        [XmlIgnore]
        public bool DefaultOfficeZoneNameSpecified { get; set; }
        
    }
}
