using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAccessDeviceFileGetRequest.
        /// <see cref="UserAccessDeviceFileGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAccessDeviceFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        public string TemplateUrl {
            get => _templateUrl;
            set {
                TemplateUrlSpecified = true;
                _templateUrl = value;
            }
        }

        [XmlIgnore]
        public bool TemplateUrlSpecified { get; set; }
        
    }
}
