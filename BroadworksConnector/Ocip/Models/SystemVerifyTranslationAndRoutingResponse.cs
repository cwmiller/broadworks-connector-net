using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents a Verify Translation and Routing Test Call Result.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVerifyTranslationAndRoutingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _result;

        [XmlElement(ElementName = "Result", IsNullable = false, Namespace = "")]
        public string Result {
            get => _result;
            set {
                ResultSpecified = true;
                _result = value;
            }
        }

        [XmlIgnore]
        public bool ResultSpecified { get; set; }
        
    }
}
