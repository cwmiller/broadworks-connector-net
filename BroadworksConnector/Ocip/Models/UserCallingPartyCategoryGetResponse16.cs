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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""89aa8c9a341a3cccb2453b1ee467bf94:201""}]")]
    public class UserCallingPartyCategoryGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:201")]
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
        public bool CategorySpecified { get; set; }

    }
}
