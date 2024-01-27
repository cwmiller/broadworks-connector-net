using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""846fcf536fcb4b0f0d32e089e99e4bfc:751""}]")]
    public abstract class SortCriteriaNumeric
    {

        protected bool _isAscending;

        [XmlElement(ElementName = "isAscending", IsNullable = false, Namespace = "")]
        [Group(@"846fcf536fcb4b0f0d32e089e99e4bfc:751")]
        public bool IsAscending
        {
            get => _isAscending;
            set
            {
                IsAscendingSpecified = true;
                _isAscending = value;
            }
        }

        [XmlIgnore]
        protected bool IsAscendingSpecified { get; set; }

    }
}
