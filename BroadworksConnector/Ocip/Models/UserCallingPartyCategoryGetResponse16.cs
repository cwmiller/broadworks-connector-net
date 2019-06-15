using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallingPartyCategoryGetRequest16.
        /// <see cref="UserCallingPartyCategoryGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallingPartyCategoryGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        public string Category {
            get => _category;
            set {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        public bool CategorySpecified { get; set; }
        
    }
}
