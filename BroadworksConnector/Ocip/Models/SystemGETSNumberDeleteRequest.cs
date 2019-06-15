using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a GETS reserved Number.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSNumberDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        public string Number {
            get => _number;
            set {
                NumberSpecified = true;
                _number = value;
            }
        }

        [XmlIgnore]
        public bool NumberSpecified { get; set; }
        
    }
}
