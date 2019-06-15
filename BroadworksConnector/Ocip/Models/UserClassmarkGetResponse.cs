using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserClassmarkGetRequest.
    /// Contains the Class Mark data
        /// <see cref="UserClassmarkGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserClassmarkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _classmark;

        [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
        public string Classmark {
            get => _classmark;
            set {
                ClassmarkSpecified = true;
                _classmark = value;
            }
        }

        [XmlIgnore]
        public bool ClassmarkSpecified { get; set; }
        
    }
}
