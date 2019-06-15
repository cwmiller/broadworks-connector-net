using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a performance measurements reporting ftp server.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPerformanceMeasurementReportingDeleteFileServerRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        public string RepositoryUrl {
            get => _repositoryUrl;
            set {
                RepositoryUrlSpecified = true;
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        public bool RepositoryUrlSpecified { get; set; }
        
    }
}
