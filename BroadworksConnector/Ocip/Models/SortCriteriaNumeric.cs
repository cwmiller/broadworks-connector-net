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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""58293b6da8bb02a6430b3eb1beb91194:737""}]")]
    public abstract class SortCriteriaNumeric
    {

        private bool _isAscending;

        [XmlElement(ElementName = "isAscending", IsNullable = false, Namespace = "")]
        [Group(@"58293b6da8bb02a6430b3eb1beb91194:737")]
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
