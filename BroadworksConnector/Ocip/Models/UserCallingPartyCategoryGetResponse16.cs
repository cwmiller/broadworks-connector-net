using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallingPartyCategoryGetRequest16.
    /// <see cref="UserCallingPartyCategoryGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d0efd2493d3062b292fd31759011925e:201""}]")]
    public class UserCallingPartyCategoryGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        [Group(@"d0efd2493d3062b292fd31759011925e:201")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Category
        {
            get => _category;
            set
            {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        protected bool CategorySpecified { get; set; }

    }
}
