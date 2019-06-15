using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupApplicationServerSetGetRequest.
    /// The response contains the group's Application Server set information.
        /// <see cref="GroupApplicationServerSetGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupApplicationServerSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
        public string ApplicationServerSetName {
            get => _applicationServerSetName;
            set {
                ApplicationServerSetNameSpecified = true;
                _applicationServerSetName = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationServerSetNameSpecified { get; set; }
        
    }
}
