using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies whether sort is
    /// ascending or descending.
    /// Sort order defaults to ascending.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
        [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.SortByAnnouncementFileSize))]
     
    public abstract class SortCriteriaNumeric 
    {

        
        private bool _isAscending;

        [XmlElement(ElementName = "isAscending", IsNullable = false, Namespace = "")]
        public bool IsAscending {
            get => _isAscending;
            set {
                IsAscendingSpecified = true;
                _isAscending = value;
            }
        }

        [XmlIgnore]
        public bool IsAscendingSpecified { get; set; }
        
    }
}
