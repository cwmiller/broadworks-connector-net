using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a GETS reserved Resource Priority.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _priorityValue;

        [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
        public string PriorityValue {
            get => _priorityValue;
            set {
                PriorityValueSpecified = true;
                _priorityValue = value;
            }
        }

        [XmlIgnore]
        public bool PriorityValueSpecified { get; set; }
        
        private string _newPriorityValue;

        [XmlElement(ElementName = "newPriorityValue", IsNullable = false, Namespace = "")]
        public string NewPriorityValue {
            get => _newPriorityValue;
            set {
                NewPriorityValueSpecified = true;
                _newPriorityValue = value;
            }
        }

        [XmlIgnore]
        public bool NewPriorityValueSpecified { get; set; }
        
        private int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        public int PriorityLevel {
            get => _priorityLevel;
            set {
                PriorityLevelSpecified = true;
                _priorityLevel = value;
            }
        }

        [XmlIgnore]
        public bool PriorityLevelSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GETSPriorityClass _priorityClass;

        [XmlElement(ElementName = "priorityClass", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GETSPriorityClass PriorityClass {
            get => _priorityClass;
            set {
                PriorityClassSpecified = true;
                _priorityClass = value;
            }
        }

        [XmlIgnore]
        public bool PriorityClassSpecified { get; set; }
        
    }
}
