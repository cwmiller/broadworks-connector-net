using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a GETS reserved Number.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSNumberAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.GETSNumberType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GETSNumberType Type {
            get => _type;
            set {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
    }
}
