using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the details of a specified service pack migration task.
    /// The response is either ServiceProviderServicePackMigrationTaskGetResponse
    /// or ErrorResponse.
    /// Replaced By: ServiceProviderServicePackMigrationTaskGetRequest14sp4
        /// <see cref="ServiceProviderServicePackMigrationTaskGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderServicePackMigrationTaskGetRequest14sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackMigrationTaskGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        public string TaskName {
            get => _taskName;
            set {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        public bool TaskNameSpecified { get; set; }
        
    }
}
