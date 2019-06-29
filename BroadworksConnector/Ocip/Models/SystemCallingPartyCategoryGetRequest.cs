using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Calling Party Category in system.
    /// The response is either a SystemCallingPartyCategoryGetResponse or an ErrorResponse.
    /// <see cref="SystemCallingPartyCategoryGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""89aa8c9a341a3cccb2453b1ee467bf94:120""}]")]
    public class SystemCallingPartyCategoryGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:120")]
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
